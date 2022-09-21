using System;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinAPI
{
    public class ProcessMemoryManager
    {
        #region DllImport
        [DllImport("kernel32.dll")]
        private static extern int GetLastError();

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(ProcessAccessFlag flag, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpBaseAddress, int dwSize, MemoryProtectedFlag flag, out int lpflOldProtect);
        #endregion

        #region Enum
        /// <summary>
        /// Process Security and Access Rights
        /// </summary>
        [Flags]
        private enum ProcessAccessFlag
        {
            PROCESS_ALL_ACCESS = (0x000F0000 | SYNCHRONIZE | 0xFFFF),
            PROCESS_CREATE_PROCESS = (0x0080),
            PROCESS_CREATE_THREAD = (0x0002),
            PROCESS_DUP_HANDLE = (0x0040),
            PROCESS_QUERY_INFORMATION = (0x0400),
            PROCESS_QUERY_LIMITED_INFORMATION = (0x1000),
            PROCESS_SET_INFORMATION = (0x0200),
            PROCESS_SET_QUOTA = (0x0100),
            PROCESS_SUSPEND_RESUME = (0x0800),
            PROCESS_TERMINATE = (0x0001),
            PROCESS_VM_OPERATION = (0x0008),
            PROCESS_VM_READ = (0x0010),
            PROCESS_VM_WRITE = (0x0020),
            SYNCHRONIZE = (0x00100000),
        }

        /// <summary>
        /// Memory Protection Constants
        /// </summary>
        [Flags]
        private enum MemoryProtectedFlag
        {
            PAGE_EXECUTE = 0x10,
            PAGE_EXECUTE_READ = 0x20,
            PAGE_EXECUTE_READWRITE = 0x40,
            PAGE_EXECUTE_WRITECOPY = 0x80,
            PAGE_NOACCESS = 0x01,
            PAGE_READONLY = 0x02,
            PAGE_READWRITE = 0x04,
            PAGE_WRITECOPY = 0x08,
            PAGE_TARGETS_INVALID = 0x40000000,
            PAGE_GUARD = 0x100,
            PAGE_NOCACHE = 0x200,
            PAGE_WRITECOMBINE = 0x400,
        }
        #endregion

        #region Member Variables
        private Process m_Process = null;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="processId">Process Id</param>
        public ProcessMemoryManager(int processId)
        {
            // Check
            if (Process.GetProcesses().Any((p) => p.Id == processId))
            {
                m_Process = Process.GetProcessById(processId);
            }
            else
            {
                // [1]
                Console.WriteLine("Process not found!");

                // [2]
                //MessageBox.Show("Process not found!");

                m_Process = null;

                return;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="processName">Process Name</param>
        public ProcessMemoryManager(string processName)
        {
            if (string.IsNullOrEmpty(processName))
            {
                // [1]
                Console.WriteLine("Process not found!");

                // [2]
                //MessageBox.Show("Process not found!");

                m_Process = null;

                return;
            }

            if (Process.GetProcessesByName(processName).Length > 0)
            {
                m_Process = Process.GetProcessesByName(processName).FirstOrDefault();
            }
            else
            {
                // [1]
                Console.WriteLine("Process not found!");

                // [2]
                //MessageBox.Show("Process not found!");

                m_Process = null;

                return;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Read the memory of the process.
        /// </summary>
        /// <param name="offset">Memory Offset</param>
        /// <param name="imageBase">Image Base</param>
        /// <param name="data">Data read from memory</param>
        /// <param name="length">Length of data</param>
        /// <param name="bytesRead">The number of bytes</param>
        /// <returns>Success(True), Failed(False)</returns>
        public bool ReadMemory(int offset, IntPtr imageBase, out byte[] data, int length, out int bytesRead)
        {
            IntPtr handle = OpenProcess(ProcessAccessFlag.PROCESS_ALL_ACCESS, false, m_Process.Id);
            IntPtr address = IntPtr.Add(imageBase, offset);

            byte[] buffer = new byte[length];

            bool rtnBool = ReadProcessMemory(handle, address, buffer, length, out bytesRead);
            data = buffer;

            return rtnBool;
        }

        public bool ReadMemoryString(int offset, IntPtr imageBase, out string str, out int bytesRead)
        {
            IntPtr handle = OpenProcess(ProcessAccessFlag.PROCESS_ALL_ACCESS, false, m_Process.Id);
            IntPtr address = IntPtr.Add(imageBase, offset);

            byte[] buffer = new byte[1];
            string rtnStr = string.Empty;

            do
            {
                ReadProcessMemory(handle, address, buffer, buffer.Length, out bytesRead);
                
                if (Convert.ToChar(buffer[0]) != '\0')
                {
                    rtnStr = rtnStr + /*BitConverter.ToChar(buffer, 0)*/Convert.ToChar(buffer[0]);
                } else { break; }
                address += 1;
            } while (true);

            str = rtnStr;

            return true;
        }

        /// <summary>
        /// Read the memory of the process.
        /// </summary>
        /// <typeparam name="T">Data Type</typeparam>
        /// <param name="offset">Memory Offset</param>
        /// <param name="imageBase">Image Base</param>
        /// <param name="data">Data read from memory</param>
        /// <param name="bytesRead">The number of bytes</param>
        /// <returns>Success(True), Failed(False)</returns>
        public bool ReadMemory<T>(int offset, IntPtr imageBase, out byte[] data, out int bytesRead)
        {
            int length = Marshal.SizeOf(typeof(T));

            IntPtr handle = OpenProcess(ProcessAccessFlag.PROCESS_ALL_ACCESS, false, m_Process.Id);
            IntPtr address = IntPtr.Add(imageBase, offset);

            byte[] buffer = new byte[length];

            bool rtnBool = ReadProcessMemory(handle, address, buffer, buffer.Length, out bytesRead);
            data = buffer;

            return rtnBool;
        }

        /// <summary>
        /// Write the memory of the process.
        /// </summary>
        /// <param name="offset">Memory Offset</param>
        /// <param name="imageBase">Image Base</param>
        /// <param name="data">Data</param>
        /// <param name="bytesRead">The number of bytes</param>
        /// <returns>Success(True), Failed(False)</returns>
        public bool WriteMemory(int offset, IntPtr imageBase, byte[] data, out int bytesWritten)
        {
            IntPtr handle = OpenProcess(ProcessAccessFlag.PROCESS_ALL_ACCESS, false, m_Process.Id);
            IntPtr address = IntPtr.Add(imageBase, offset);

            bool rtnBool1 = VirtualProtectEx(handle, address, data.Length, MemoryProtectedFlag.PAGE_EXECUTE_READWRITE, out int oldProtect);
            bool rtnBool2 = WriteProcessMemory(handle, address, data, data.Length, out bytesWritten);
            bool rtnBool3 = VirtualProtectEx(handle, address, data.Length, (MemoryProtectedFlag)oldProtect, out oldProtect);

            return rtnBool1 && rtnBool2 && rtnBool3;
        }
        #endregion
    }
}
