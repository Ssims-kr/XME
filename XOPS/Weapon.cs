using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOPS
{
    /// <summary>
    /// 무기 관리 클래스
    /// </summary>
    public class Weapon
    {
        #region 상수
        /// <summary>
        /// 최대 무기 개수
        /// </summary>
        public const int MAX_WEAPON = 23;

        /// <summary>
        /// 최대 무기 이름 글자 수
        /// </summary>
        public const int MAX_WEAPON_NAME_LENGTH = 15;

        /// <summary>
        /// 각 능력치의 최소값
        /// </summary>
        public const int MIN_VALUE = -255;

        /// <summary>
        /// 각 능력치의 최대값
        /// </summary>
        public const int MAX_VALUE = 255;
        #endregion

        #region 내부 클래스
        public class WeaponParameter
        {
            #region 프로퍼티
            public string Name { get; set; }
            public short Damage { get; set; }
            public short Penetration { get; set; }
            public short Speed { get; set; }
            public short Velocity { get; set; }
            public short Ammo { get; set; }
            public short ReloadTime { get; set; }
            public short Reaction { get; set; }
            public short AccuracyMin { get; set; }
            public short AccuracyMax { get; set; }
            public short PositionX { get; set; }
            public short PositionY { get; set; }
            public short PositionZ { get; set; }
            public short MFlashPositionX { get; set; }
            public short MFlashPositionY { get; set; }
            public short MFlashPositionZ { get; set; }
            public short ShellPositionX { get; set; }
            public short ShellPositionY { get; set; }
            public short ShellPositionZ { get; set; }
            public short Arms { get; set; }
            public short FireMode { get; set; }
            public short ScopeMode { get; set; }
            public short TextureID { get; set; }
            public short ModelID { get; set; }
            public short Size { get; set; }
            public short ShellMovementPositionX { get; set; }
            public short ShellMovementPositionY { get; set; }
            public short SoundID { get; set; }
            public short SoundVolume { get; set; }
            public short Silencer { get; set; }
            #endregion
        }
        #endregion

        #region 열거형
        public enum WeaponID
        {
            UNKNOWN = -1,
            NONE,
            MP5,
            PSG1,
            M92F,
            GLOCK18_SEMI,
            DE,
            MAC10,
            UMP,
            P90,
            M4,
            AK47,
            AUG,
            M249,
            GRENADE,
            MP5SD,
            CASE,
            GLOCK18_FULL,
            M1911,
            GLOCK17,
            M1,
            FAMAS,
            MK23,
            MK23SD,
        }

        public enum ArmsType
        {
            UNKNOWN = -1,
            ARM00 = 27,
            ARM01 = 9,
            ARM02 = 8,
        }

        public enum FireMode
        {
            UNKNOWN = -1,
            FULL = 0,
            SEMI = 1,
        }

        public enum ScopeMode
        {
            UNKNOWN = -1,
            NONE = 0,
            DOUBLE = 1,
            QUAD = 2,
            ONE = 3,
        }

        public enum TextureID
        {
            UNKNOWN = -1,
            NONE = 0,
            MP5 = 16,
            PSG1 = 11,
            M92F = 19,
            GLOCK18 = 17,
            DE = 50,
            MAC10 = 40,
            UMP = 39,
            P90 = 36,
            M4 = 38,
            AK47 = 33,
            AUG = 51,
            M249 = 37,
            GRENADE = 32,
            MP5SD = 34,
            CASE = 44,
            M1911 = 45,
            GLOCK17 = 48,
            M1 = 54,
            FAMAS = 55,
            MK23 = 56,
        }

        public enum ModelID
        {
            UNKNOWN = -1,
            NONE = 0,
            MP5 = 11,
            PSG1 = 10,
            M92F = 13,
            GLOCK = 16,
            DE = 21,
            MAC10 = 14,
            UMP = 30,
            P90 = 15,
            M4 = 29,
            AK47 = 24,
            AUG = 22,
            M249 = 28,
            GRENADE = 23,
            MP5SD = 25,
            CASE = 32,
            M1911 = 34,
            M1 = 57,
            FAMAS = 58,
            MK23 = 59,
            MK23SD = 60,
        }

        public enum SoundID
        {
            UNKNOWN = -1,
            BANG1 = 0,
            BANG2 = 1,
            BANG3 = 2,
            BANG4 = 3,
            HIT1 = 4,
            HIT2 = 5,
            HIT3 = 6,
            BANG = 7,
            HYU = 8,
            KA = 9,
            CAN = 10,
            CCO = 11,
            DAN = 12,
            BANG5 = 13,
        }
        #endregion

        #region 멤버 변수
        private XOperations.Version m_Version;
        private WeaponParameter[] m_WeaponParameter;
        #endregion

        #region 프로퍼티
        /// <summary>
        /// 무기 파라미터의 정보를 취득하거나 설정할 수 있다.
        /// </summary>
        public WeaponParameter this[int index] { get { return m_WeaponParameter[index]; } set { m_WeaponParameter[index] = value; } }
        #endregion

        #region 생성자
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Weapon()
        {
            m_Version = XOperations.Version.None;
            m_WeaponParameter = null;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="ver">X Operations의 버전</param>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        public Weapon(XOperations.Version ver, string filePath)
        {
            m_Version = ver;
            m_WeaponParameter = new WeaponParameter[MAX_WEAPON];
            for (int i = 0; i < MAX_WEAPON; i++)
            {
                m_WeaponParameter[i] = new WeaponParameter();
            }

            if (ReadData(filePath) == false)
            {
                MessageBox.Show("무기 데이터 읽어오기 실패!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                m_WeaponParameter = null;
                return;
            }
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="ver">X Operations의 버전</param>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        public Weapon(XOperations.Version ver, int processId)
        {
            m_Version = ver;
            m_WeaponParameter = new WeaponParameter[MAX_WEAPON];
            for (int i = 0; i < MAX_WEAPON; i++)
            {
                m_WeaponParameter[i] = new WeaponParameter();
            }

            if (ReadMemoryData(processId) == false)
            {
                MessageBox.Show("무기 데이터 읽어오기 실패!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                m_WeaponParameter = null;
                return;
            }
        }
        #endregion

        #region 메서드
        /// <summary>
        /// X Operations의 무기 데이터를 읽어옵니다.
        /// </summary>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool ReadMemoryData(int processId)
        {
            // 프로세스 검사
            if (Process.GetProcesses().Any(p => p.Id == processId) == false) { return false; }

            // 버전 검사
            if (m_Version == XOperations.Version.None || m_Version == XOperations.Version.XOPS093 || m_Version == XOperations.Version.XOPSOLT16 || m_Version == XOperations.Version.XOPSOLT17) { return false; }
            
            // 데이터 읽기
            {
                WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

                // 무기 이름
                for (int i = 0; i < MAX_WEAPON; i++)
                {
                    long offset = XOPSOffsetManager.GetWeaponNameOffset(m_Version, (WeaponID)i);
                    if (offset == -1) { return false; }

                    pmm.ReadMemoryString((int)offset, new IntPtr(0x400000), out string name, out int bytesRead);
                    m_WeaponParameter[i].Name = name;
                }

                // 무기 데이터
                long offset2 = XOPSOffsetManager.GetWeaponOffset(m_Version);
                if (offset2 == -1) { return false; }

                byte[] data = new byte[2];
                for (int i = 0; i < MAX_WEAPON; i++)
                {
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out int bytesRead2);
                    m_WeaponParameter[i].Damage = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Penetration = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Speed = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Velocity = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Ammo = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ReloadTime = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Reaction = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].AccuracyMin = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].AccuracyMax = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].PositionX = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].PositionY = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].PositionZ = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].MFlashPositionX = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].MFlashPositionY = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].MFlashPositionZ = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ShellPositionX = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ShellPositionY = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ShellPositionZ = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Arms = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].FireMode = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ScopeMode = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].TextureID = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ModelID = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Size = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ShellMovementPositionX = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].ShellMovementPositionY = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].SoundID = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].SoundVolume = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                    pmm.ReadMemory<short>((int)offset2, new IntPtr(0x400000), out data, out bytesRead2);
                    m_WeaponParameter[i].Silencer = BitConverter.ToInt16(data, 0);

                    offset2 += 2;
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 무기 데이터를 작성합니다.
        /// </summary>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool WriteMemoryData(int processId)
        {
            // 프로세스 검사
            if (Process.GetProcesses().Any(p => p.Id == processId) == false) { return false; }

            // 버전 검사
            if (m_Version == XOperations.Version.None || m_Version == XOperations.Version.XOPS093 || m_Version == XOperations.Version.XOPSOLT16 || m_Version == XOperations.Version.XOPSOLT17) { return false; }

            // 데이터 전처리 함수
            Func<short, short> convert = (short target) =>
            {
                short rtnShort = target;

                if (rtnShort > MAX_VALUE) { rtnShort = MAX_VALUE; }
                if (rtnShort < MIN_VALUE) { rtnShort = MIN_VALUE; }

                return rtnShort;
            };

            // 데이터 쓰기
            {
                WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

                // 무기 이름
                for (int i = 0; i < MAX_WEAPON; i++)
                {
                    long offset = XOPSOffsetManager.GetWeaponNameOffset(m_Version, (WeaponID)i);
                    if (offset == -1) { return false; }

                    byte[] buffer = new byte[MAX_WEAPON_NAME_LENGTH];
                    if (m_WeaponParameter[i].Name.Length > MAX_WEAPON_NAME_LENGTH)
                    {
                        string name = m_WeaponParameter[i].Name.Substring(0, MAX_WEAPON_NAME_LENGTH);

                        pmm.WriteMemory((int)offset, new IntPtr(0x400000), buffer, out int bytesWritten);
                        pmm.WriteMemory((int)offset, new IntPtr(0x400000), Encoding.ASCII.GetBytes(name), out bytesWritten);
                    }
                    else
                    {
                        pmm.WriteMemory((int)offset, new IntPtr(0x400000), buffer, out int bytesWritten);
                        pmm.WriteMemory((int)offset, new IntPtr(0x400000), Encoding.ASCII.GetBytes(m_WeaponParameter[i].Name), out bytesWritten);
                    }
                }

                // 무기 데이터
                long offset2 = XOPSOffsetManager.GetWeaponOffset(m_Version);
                if (offset2 == -1) { return false; }

                for (int i = 0; i < MAX_WEAPON; i++)
                {
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Damage)), out int bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Penetration)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Speed)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Velocity)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Ammo)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ReloadTime)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Reaction)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].AccuracyMin)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].AccuracyMax)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].PositionX)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].PositionY)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].PositionZ)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].MFlashPositionX)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].MFlashPositionY)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].MFlashPositionZ)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ShellPositionX)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ShellPositionY)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ShellPositionZ)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Arms)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].FireMode)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ScopeMode)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].TextureID)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ModelID)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Size)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ShellMovementPositionX)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].ShellMovementPositionY)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].SoundID)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].SoundVolume)), out bytesWritten);

                    offset2 += 2;
                    pmm.WriteMemory((int)offset2, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_WeaponParameter[i].Silencer)), out bytesWritten);

                    offset2 += 2;
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 무기 데이터를 읽어옵니다.
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool ReadData(string filePath)
        {
            // 빈 경로 검사
            if (string.IsNullOrEmpty(filePath)) { return false; }

            // 버전 검사
            if (m_Version == XOperations.Version.None || m_Version == XOperations.Version.XOPS093 || m_Version == XOperations.Version.XOPSOLT16 || m_Version == XOperations.Version.XOPSOLT17) { return false; }

            // '\0'를 만날 때까지 읽는 메서드
            Func<BinaryReader, string> ReadString = (BinaryReader reader) =>
            {
                string s = string.Empty;
                char c = char.MinValue;

                while ((int)(c = reader.ReadChar()) != '\0') { s += c; }

                return s;
            };

            // 데이터 읽기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    // 무기 이름
                    for (int i = 0; i < MAX_WEAPON; i++)
                    {
                        long offset = XOPSOffsetManager.GetWeaponNameOffset(m_Version, (WeaponID)i);
                        if (offset == -1) { return false; }

                        br.BaseStream.Position = offset;
                        //m_WeaponParameter[i].Name = ReadString(br);
                        m_WeaponParameter[i].Name = Encoding.ASCII.GetString(br.ReadBytes(MAX_WEAPON_NAME_LENGTH));
                    }

                    // 무기 데이터
                    long offset2 = XOPSOffsetManager.GetWeaponOffset(m_Version);
                    if (offset2 == -1) { return false; }

                    br.BaseStream.Position = offset2;
                    for (int i = 0; i < MAX_WEAPON; i++)
                    {
                        /* 아래의 순서를 지켜야 함. */
                        m_WeaponParameter[i].Damage = br.ReadInt16();
                        m_WeaponParameter[i].Penetration = br.ReadInt16();
                        m_WeaponParameter[i].Speed = br.ReadInt16();
                        m_WeaponParameter[i].Velocity = br.ReadInt16();
                        m_WeaponParameter[i].Ammo = br.ReadInt16();
                        m_WeaponParameter[i].ReloadTime = br.ReadInt16();
                        m_WeaponParameter[i].Reaction = br.ReadInt16();
                        m_WeaponParameter[i].AccuracyMin = br.ReadInt16();
                        m_WeaponParameter[i].AccuracyMax = br.ReadInt16();
                        m_WeaponParameter[i].PositionX = br.ReadInt16();
                        m_WeaponParameter[i].PositionY = br.ReadInt16();
                        m_WeaponParameter[i].PositionZ = br.ReadInt16();
                        m_WeaponParameter[i].MFlashPositionX= br.ReadInt16();
                        m_WeaponParameter[i].MFlashPositionY = br.ReadInt16();
                        m_WeaponParameter[i].MFlashPositionZ = br.ReadInt16();
                        m_WeaponParameter[i].ShellPositionX = br.ReadInt16();
                        m_WeaponParameter[i].ShellPositionY = br.ReadInt16();
                        m_WeaponParameter[i].ShellPositionZ = br.ReadInt16();
                        m_WeaponParameter[i].Arms = br.ReadInt16();
                        m_WeaponParameter[i].FireMode = br.ReadInt16();
                        m_WeaponParameter[i].ScopeMode = br.ReadInt16();
                        m_WeaponParameter[i].TextureID = br.ReadInt16();
                        m_WeaponParameter[i].ModelID = br.ReadInt16();
                        m_WeaponParameter[i].Size = br.ReadInt16();
                        m_WeaponParameter[i].ShellMovementPositionX = br.ReadInt16();
                        m_WeaponParameter[i].ShellMovementPositionY = br.ReadInt16();
                        m_WeaponParameter[i].SoundID = br.ReadInt16();
                        m_WeaponParameter[i].SoundVolume = br.ReadInt16();
                        m_WeaponParameter[i].Silencer = br.ReadInt16();
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 무기 데이터를 저장합니다.
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool SaveData(string filePath)
        {
            // 빈 경로 검사
            if (string.IsNullOrEmpty(filePath)) { return false; }

            // 버전 검사
            if (m_Version == XOperations.Version.None || m_Version == XOperations.Version.XOPS093 || m_Version == XOperations.Version.XOPSOLT16 || m_Version == XOperations.Version.XOPSOLT17) { return false; }

            // 데이터 전처리 함수
            Func<short, short> convert = (short target) =>
            {
                short rtnShort = target;

                if (rtnShort > MAX_VALUE) { rtnShort = MAX_VALUE; }
                if (rtnShort < MIN_VALUE) { rtnShort = MIN_VALUE; }

                return rtnShort;
            };

            // 데이터 쓰기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // 무기 이름
                    for (int i = 0; i < MAX_WEAPON; i++)
                    {
                        long offset = XOPSOffsetManager.GetWeaponNameOffset(m_Version, (WeaponID)i);
                        if (offset == -1) { return false; }

                        bw.BaseStream.Position = offset;
                        if (m_WeaponParameter[i].Name.Length > MAX_WEAPON_NAME_LENGTH)
                        {
                            string name = m_WeaponParameter[i].Name.Substring(0, MAX_WEAPON_NAME_LENGTH - 1);
                            bw.Write(Encoding.ASCII.GetBytes(name));
                        }
                        else
                        {
                            bw.Write(Encoding.ASCII.GetBytes(m_WeaponParameter[i].Name));
                        }
                    }

                    // 무기 데이터
                    long offset2 = XOPSOffsetManager.GetWeaponOffset(m_Version);
                    if (offset2 == -1) { return false; }

                    bw.BaseStream.Position = offset2;
                    for (int i = 0; i < MAX_WEAPON; i++)
                    {
                        /* 아래의 순서를 지켜야 함. */
                        bw.Write(convert(m_WeaponParameter[i].Damage));
                        bw.Write(convert(m_WeaponParameter[i].Penetration));
                        bw.Write(convert(m_WeaponParameter[i].Speed));
                        bw.Write(convert(m_WeaponParameter[i].Velocity));
                        bw.Write(convert(m_WeaponParameter[i].Ammo));
                        bw.Write(convert(m_WeaponParameter[i].ReloadTime));
                        bw.Write(convert(m_WeaponParameter[i].Reaction));
                        bw.Write(convert(m_WeaponParameter[i].AccuracyMin));
                        bw.Write(convert(m_WeaponParameter[i].AccuracyMax));
                        bw.Write(convert(m_WeaponParameter[i].PositionX));
                        bw.Write(convert(m_WeaponParameter[i].PositionY));
                        bw.Write(convert(m_WeaponParameter[i].PositionZ));
                        bw.Write(convert(m_WeaponParameter[i].MFlashPositionX));
                        bw.Write(convert(m_WeaponParameter[i].MFlashPositionY));
                        bw.Write(convert(m_WeaponParameter[i].MFlashPositionZ));
                        bw.Write(convert(m_WeaponParameter[i].ShellPositionX));
                        bw.Write(convert(m_WeaponParameter[i].ShellPositionY));
                        bw.Write(convert(m_WeaponParameter[i].ShellPositionZ));
                        bw.Write(convert(m_WeaponParameter[i].Arms));
                        bw.Write(convert(m_WeaponParameter[i].FireMode));
                        bw.Write(convert(m_WeaponParameter[i].ScopeMode));
                        bw.Write(convert(m_WeaponParameter[i].TextureID));
                        bw.Write(convert(m_WeaponParameter[i].ModelID));
                        bw.Write(convert(m_WeaponParameter[i].Size));
                        bw.Write(convert(m_WeaponParameter[i].ShellMovementPositionX));
                        bw.Write(convert(m_WeaponParameter[i].ShellMovementPositionY));
                        bw.Write(convert(m_WeaponParameter[i].SoundID));
                        bw.Write(convert(m_WeaponParameter[i].SoundVolume));
                        bw.Write(convert(m_WeaponParameter[i].Silencer));
                    }
                }
            }

            return true;
        }
        #endregion
    }
}
