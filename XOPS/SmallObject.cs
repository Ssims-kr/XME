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
    /// 소품 관리 클래스
    /// </summary>
    public class SmallObject
    {
        #region 상수
        public const int MAX_SMALLOBJECT = 12;
        #endregion

        #region 내부 클래스
        public class SmallObjectParameter
        {
            #region 프로퍼티
            public byte Jump { get; set; }
            public byte ModelID { get; set; }
            public byte TextureID { get; set; }
            public byte CollisionRange { get; set; }
            public byte HP { get; set; }
            public byte SoundID { get; set; }
            #endregion
        }
        #endregion

        #region 열거형
        public enum SmallObjectID
        {
            CAN = 0,
            PC,
            PC2,
            PC3,
            PC_WIDE,
            PC2_WIDE,
            PC3_WIDE,
            CHAIR,
            BOX,
            PC_RUNNING,
            PC_RUNNING_DARK,
            CONE,
        }

        public enum ModelID
        {
            UNKNOWN = -1,
            UP0 = 0,
            LEG,
            RUN01,
            RUN02,
            RUN03,
            RUN04,
            RUN05,
            RUN06,
            ARM01,
            ARM02,
            PSG1,
            MP5,
            BULLET,
            M92F,
            MAC10,
            P90,
            GLOCK18,
            WALK1,
            WALK2,
            WALK3,
            WALK4,
            DE,
            AUG,
            GRENADE,
            AK47,
            MP5SD,
            SKY,
            ARM00,
            M249,
            M4,
            UMP,
            UP1,
            CASE,
            UP2,
            M1911,
            UP3,
            UP4,
            CAN,
            UP5,
            PC,
            PC2,
            PC3,
            PC_WIDE,
            PC2_WIDE,
            PC3_WIDE,
            CHAIR,
            BOX,
            M1 = 57,
            FAMAS,
            MK23,
            MK23SD,
            CONE,
            ADD_SMALLOBJECT
        }

        public enum TextureID
        {
            UNKNOWN = -1,
            PSG1 = 11,
            SMOKE,
            MUZZLE_FLASH,
            BLOOD,
            YAKKYOU,
            MP5,
            GLOCK18,
            BULLET,
            M92F,
            CHAR = 30,
            TITLE,
            GRENADE,
            AK47,
            MP5SD,
            P90 = 36,
            M249,
            M4,
            UMP,
            MAC10,
            CAN,
            SKY1,
            CASE = 44,
            M1911,
            PC,
            CHAIR,
            GLOCK17,
            BOX,
            DE,
            AUG,
            PC_SW,
            PC_D,
            M1,
            FAMAS,
            MK23,
            CONE,
            ADD_SMALLOBJECT,
        }

        public enum SoundID
        {
            UNKNOWN = -1,
            BANG1 = 0,
            BANG2,
            BANG3,
            BANG4,
            HIT1,
            HIT2,
            HIT3,
            BANG,
            HYU,
            KA,
            CAN,
            CCO,
            DAN,
            BANG5,
            ADD_SMALLOBJECT,
        }
        #endregion

        #region 멤버 변수
        private XOperations.Version m_Version;
        private SmallObjectParameter[] m_SmallObjectParameter;
        #endregion

        #region 프로퍼티
        /// <summary>
        /// 소품 파라미터의 정보를 취득하거나 설정할 수 있다.
        /// </summary>
        public SmallObjectParameter this[int index] { get { return m_SmallObjectParameter[index]; } set { m_SmallObjectParameter[index] = value; } }
        #endregion

        #region 생성자
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public SmallObject()
        {
            m_Version = XOperations.Version.None;
            m_SmallObjectParameter = new SmallObjectParameter[MAX_SMALLOBJECT];
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="ver">X Operations의 버전</param>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        public SmallObject(XOperations.Version ver, string filePath)
        {
            m_Version = ver;
            m_SmallObjectParameter = new SmallObjectParameter[MAX_SMALLOBJECT];
            for (int i = 0; i < MAX_SMALLOBJECT; i++)
            {
                m_SmallObjectParameter[i] = new SmallObjectParameter();
            }

            if (ReadData(filePath) == false)
            {
                MessageBox.Show("소품 데이터 읽어오기 실패!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                m_SmallObjectParameter = null;
                return;
            }
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="ver">X Operations의 버전</param>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        public SmallObject(XOperations.Version ver, int processId)
        {
            m_Version = ver;
            m_SmallObjectParameter = new SmallObjectParameter[MAX_SMALLOBJECT];
            for (int i = 0; i < MAX_SMALLOBJECT; i++)
            {
                m_SmallObjectParameter[i] = new SmallObjectParameter();
            }

            if (ReadMemoryData(processId) == false)
            {
                MessageBox.Show("소품 데이터 읽어오기 실패!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                m_SmallObjectParameter = null;
                return;
            }
        }
        #endregion

        #region 메서드
        /// <summary>
        /// X Operations의 소품 데이터를 읽어옵니다.
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

                // 소품 데이터
                long offset = XOPSOffsetManager.GetSmallObjectOffset(m_Version);
                if (offset == -1) { return false; }

                byte[] data = new byte[1];
                for (int i = 0; i < MAX_SMALLOBJECT; i++)
                {
                    pmm.ReadMemory<byte>((int)offset, new IntPtr(0x400000), out data, out int bytesRead);
                    m_SmallObjectParameter[i].Jump = data.First();

                    offset += bytesRead;
                    pmm.ReadMemory<byte>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_SmallObjectParameter[i].ModelID = data.First();

                    offset += bytesRead;
                    pmm.ReadMemory<byte>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_SmallObjectParameter[i].TextureID = data.First();

                    offset += bytesRead;
                    pmm.ReadMemory<byte>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_SmallObjectParameter[i].CollisionRange = data.First();

                    offset += bytesRead;
                    pmm.ReadMemory<byte>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_SmallObjectParameter[i].HP = data.First();

                    offset += bytesRead;
                    pmm.ReadMemory<byte>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_SmallObjectParameter[i].SoundID = data.First();

                    offset += bytesRead;
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 소품 데이터를 작성합니다.
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
            Func<byte, byte> convert = (byte target) =>
            {
                byte rtnByte = target;

                if (rtnByte > byte.MaxValue) { rtnByte = byte.MaxValue; }
                if (rtnByte < 0) { rtnByte = 0; }

                return rtnByte;
            };

            // 데이터 쓰기
            {
                WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

                // 소품 데이터
                long offset = XOPSOffsetManager.GetSmallObjectOffset(m_Version);
                if (offset == -1) { return false; }

                byte[] data = new byte[1];
                for (int i = 0; i < MAX_SMALLOBJECT; i++)
                {
                    data[0] = convert(m_SmallObjectParameter[i].Jump);
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), data, out int bytesWritten);

                    offset += bytesWritten;
                    data[0] = convert(m_SmallObjectParameter[i].ModelID);
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), data, out bytesWritten);

                    offset += bytesWritten;
                    data[0] = convert(m_SmallObjectParameter[i].TextureID);
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), data, out bytesWritten);

                    offset += bytesWritten;
                    data[0] = convert(m_SmallObjectParameter[i].CollisionRange);
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), data, out bytesWritten);

                    offset += bytesWritten;
                    data[0] = convert(m_SmallObjectParameter[i].HP);
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), data, out bytesWritten);

                    offset += bytesWritten;
                    data[0] = convert(m_SmallObjectParameter[i].SoundID);
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), data, out bytesWritten);

                    offset += bytesWritten;
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 소품 데이터를 읽어옵니다.
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool ReadData(string filePath)
        {
            // 빈 경로 검사
            if (string.IsNullOrEmpty(filePath)) { return false; }

            // 버전 검사
            if (m_Version == XOperations.Version.None || m_Version == XOperations.Version.XOPS093 || m_Version == XOperations.Version.XOPSOLT16 || m_Version == XOperations.Version.XOPSOLT17) { return false; }

            // 데이터 읽기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    // 소품 데이터
                    long offset = XOPSOffsetManager.GetSmallObjectOffset(m_Version);
                    if (offset == -1) { return false; }

                    br.BaseStream.Position = offset;
                    for (int i = 0; i < MAX_SMALLOBJECT; i++)
                    {
                        /* 아래의 순서를 지켜야 함 */
                        m_SmallObjectParameter[i].Jump = br.ReadByte();
                        m_SmallObjectParameter[i].ModelID = br.ReadByte();
                        m_SmallObjectParameter[i].TextureID = br.ReadByte();
                        m_SmallObjectParameter[i].CollisionRange = br.ReadByte();
                        m_SmallObjectParameter[i].HP = br.ReadByte();
                        m_SmallObjectParameter[i].SoundID = br.ReadByte();
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 소품 데이터를 저장합니다.
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
            Func<byte, byte> convert = (byte target) =>
            {
                byte rtnByte = target;

                if (rtnByte > byte.MaxValue) { rtnByte = byte.MaxValue; }
                if (rtnByte < 0) { rtnByte = 0; }

                return rtnByte;
            };

            // 데이터 쓰기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // 소품 데이터
                    long offset = XOPSOffsetManager.GetSmallObjectOffset(m_Version);
                    if (offset == -1) { return false; }

                    bw.BaseStream.Position = offset;
                    for (int i = 0; i < MAX_SMALLOBJECT; i++)
                    {
                        /* 아래의 순서를 지켜야 함 */
                        bw.Write(convert(m_SmallObjectParameter[i].Jump));
                        bw.Write(convert(m_SmallObjectParameter[i].ModelID));
                        bw.Write(convert(m_SmallObjectParameter[i].TextureID));
                        bw.Write(convert(m_SmallObjectParameter[i].CollisionRange));
                        bw.Write(convert(m_SmallObjectParameter[i].HP));
                        bw.Write(convert(m_SmallObjectParameter[i].SoundID));
                    }
                }
            }

            return true;
        }
        #endregion
    }
}
