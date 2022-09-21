using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace XOPS
{
    /// <summary>
    /// 캐릭터 관리 클래스
    /// </summary>
    public class Character
    {
        #region 상수
        /// <summary>
        /// 최대 캐릭터의 수
        /// </summary>
        public const int MAX_CHARACTER = 43;
        #endregion

        #region 내부 클래스
        public class CharacterParameter
        {
            #region 프로퍼티
            public short TextureID { get; set; }
            public short ModelID { get; set; }
            public short HP { get; set; }
            public short AILevel { get; set; }
            public short PrimaryWeapon { get; set; }
            public short SecondaryWeapon { get; set; }
            public short Type { get; set; }
            #endregion
        }
        #endregion

        #region 열거형
        public enum CharacterID
        {
            SPECIAL_FORCE_BLACK_A = 0,
            SPECIAL_FORCE_BLACK_B,
            SPECIAL_FORCE_GREEN_A,
            SPECIAL_FORCE_GREEN_B,
            SPECIAL_FORCE_GREEN_C,
            SPECIAL_FORCE_WHITE_A,
            SPECIAL_FORCE_WHITE_B,
            HAGE,
            SPECIAL_FORCE_VIOLET,
            SPECIAL_FORCE_BLUE,
            ROBOT,
            GS_SG,
            GS,
            RIIMAN_G,
            POLICE,
            RIIMAN,
            SYATU,
            ISLAM,
            WOMAN,
            CIV1,
            CIV2,
            CIV3,
            SYATU_SG,
            CIV1_SG,
            CIV2_SG,
            CIV3_SG,
            SOLDIER0,
            SOLDIER1,
            SOLDIER2,
            ZOMBIE1,
            ZOMBIE2,
            ZOMBIE3,
            ZOMBIE4,
            RIIMAN_K,
            RIIMAN_K_SG,
            ISLAM2,
            RIIMAN_B,
            RIIMAN_B_SG,
            SYATU2,
            SOLDIER3,
            SOLDIER3_SG,
            GATES,
            GATES_SG,
        }

        public enum TextureID
        {
            UNKNOWN = -1,
            SOLDIER_BLACK = 0,
            SOLDIER_GREEN,
            SOLDIER_WHITE,
            HAGE,
            SOLDIER_VIOLET,
            SOLDIER_BLUE,
            ROBOT,
            GS,
            SOLDIER0,
            POLICE,
            RIIMAN,
            SYATU,
            ISLAM,
            WOMAN,
            CIV1,
            CIV2,
            CIV3,
            SOLDIER1,
            SOLDIER2,
            ZOMBIE1,
            ZOMBIE2,
            ZOMBIE3,
            ZOMBIE4,
            RIIMAN_G,
            RIIMAN_K,
            ISLAM2,
            RIIMAN_B,
            SYATU2,
            SOLDIER3,
            GATES,
        }

        public enum ModelID
        {
            UNKNOWN = -1,
            UP0 = 0,
            UP1 = 31,
            UP2 = 33,
            UP3 = 35,
            UP4 = 36,
            UP5 = 38,
        }

        public enum AILevel
        {
            UNKNOWN = -1,
            NOT = 0,
            D,
            C,
            B,
            A,
            S,
            SS,
            NOT_USE_WEAPON = 9,
        }

        public enum Type
        {
            UNKNOWN = -1,
            HUMAN = 0,
            ROBOT,
            ZOMBIE,
        }
        #endregion

        #region 멤버 변수
        private XOperations.Version m_Version;
        private CharacterParameter[] m_CharacterParameter;
        #endregion

        #region 프로퍼티
        public CharacterParameter this[int index] { get { return m_CharacterParameter[index]; } set { m_CharacterParameter[index] = value; } }
        #endregion

        #region 생성자
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Character()
        {
            m_Version = XOperations.Version.None;
            m_CharacterParameter = null;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="ver">X Operations의 버전</param>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        public Character(XOperations.Version ver, string filePath)
        {
            m_Version = ver;
            m_CharacterParameter = new CharacterParameter[MAX_CHARACTER];
            for (int i = 0; i < MAX_CHARACTER; i++)
            {
                m_CharacterParameter[i] = new CharacterParameter();
            }

            if (ReadData(filePath) == false)
            {
                MessageBox.Show("캐릭터 데이터 읽어오기 실패!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                m_CharacterParameter = null;
                return;
            }
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="ver">X Operations의 버전</param>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        public Character(XOperations.Version ver, int processId)
        {
            m_Version = ver;
            m_CharacterParameter = new CharacterParameter[MAX_CHARACTER];
            for (int i = 0; i < MAX_CHARACTER; i++)
            {
                m_CharacterParameter[i] = new CharacterParameter();
            }

            if (ReadMemoryData(processId) == false)
            {
                MessageBox.Show("캐릭터 데이터 읽어오기 실패!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                m_CharacterParameter = null;
                return;
            }
        }
        #endregion

        #region 메서드
        /// <summary>
        /// X Operations의 캐릭터 데이터를 읽어옵니다.
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

                // 캐릭터 데이터
                long offset = XOPSOffsetManager.GetCharacterOffset(m_Version);
                if (offset == -1) { return false; }

                byte[] data = new byte[2];
                for (int i = 0; i < MAX_CHARACTER; i++)
                {
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out int bytesRead);
                    m_CharacterParameter[i].TextureID = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_CharacterParameter[i].ModelID = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_CharacterParameter[i].HP = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_CharacterParameter[i].AILevel = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_CharacterParameter[i].SecondaryWeapon = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_CharacterParameter[i].PrimaryWeapon = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                    pmm.ReadMemory<short>((int)offset, new IntPtr(0x400000), out data, out bytesRead);
                    m_CharacterParameter[i].Type = BitConverter.ToInt16(data, 0);

                    offset += bytesRead;
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 캐릭터 데이터를 작성합니다.
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

                if (rtnShort > short.MaxValue) { rtnShort = short.MaxValue; }
                if (rtnShort < 0) { rtnShort = 0; }

                return rtnShort;
            };

            // 데이터 쓰기
            {
                WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

                // 캐릭터 데이터
                long offset = XOPSOffsetManager.GetCharacterOffset(m_Version);
                if (offset == -1) { return false; }

                for (int i = 0; i < MAX_CHARACTER; i++)
                {
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].TextureID)), out int bytesWritten);

                    offset += bytesWritten;
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].ModelID)), out bytesWritten);

                    offset += bytesWritten;
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].HP)), out bytesWritten);

                    offset += bytesWritten;
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].AILevel)), out bytesWritten);

                    offset += bytesWritten;
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].SecondaryWeapon)), out bytesWritten);

                    offset += bytesWritten;
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].PrimaryWeapon)), out bytesWritten);

                    offset += bytesWritten;
                    pmm.WriteMemory((int)offset, new IntPtr(0x400000), BitConverter.GetBytes(convert(m_CharacterParameter[i].Type)), out bytesWritten);

                    offset += bytesWritten;
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 캐릭터 데이터를 읽어옵니다.
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
                    // 캐릭터 데이터
                    long offset = XOPSOffsetManager.GetCharacterOffset(m_Version);
                    if (offset == -1) { return false; }

                    br.BaseStream.Position = offset;
                    for (int i = 0; i < MAX_CHARACTER; i++)
                    {
                        /* 아래의 순서를 지켜야 함 */
                        m_CharacterParameter[i].TextureID = br.ReadInt16();
                        m_CharacterParameter[i].ModelID = br.ReadInt16();
                        m_CharacterParameter[i].HP = br.ReadInt16();
                        m_CharacterParameter[i].AILevel = br.ReadInt16();
                        m_CharacterParameter[i].SecondaryWeapon = br.ReadInt16();
                        m_CharacterParameter[i].PrimaryWeapon = br.ReadInt16();
                        m_CharacterParameter[i].Type = br.ReadInt16();
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations의 캐릭터 데이터를 저장합니다.
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

                if (rtnShort > short.MaxValue) { rtnShort = short.MaxValue; }
                if (rtnShort < 0) { rtnShort = 0; }

                return rtnShort;
            };

            // 데이터 쓰기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // 캐릭터 데이터
                    long offset = XOPSOffsetManager.GetCharacterOffset(m_Version);
                    if (offset == -1) { return false; }

                    bw.BaseStream.Position = offset;
                    for (int i = 0; i < MAX_CHARACTER; i++)
                    {
                        /* 아래의 순서를 지켜야 함 */
                        bw.Write(convert(m_CharacterParameter[i].TextureID));
                        bw.Write(convert(m_CharacterParameter[i].ModelID));
                        bw.Write(convert(m_CharacterParameter[i].HP));
                        bw.Write(convert(m_CharacterParameter[i].AILevel));
                        bw.Write(convert(m_CharacterParameter[i].SecondaryWeapon));
                        bw.Write(convert(m_CharacterParameter[i].PrimaryWeapon));
                        bw.Write(convert(m_CharacterParameter[i].Type));
                    }
                }
            }

            return true;
        }
        #endregion
    }
}
