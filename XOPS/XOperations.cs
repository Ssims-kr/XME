using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinPE;

namespace XOPS
{
    /// <summary>
    /// X Operations 관리 클래스
    /// </summary>
    public class XOperations
    {
        #region 상수
        /// <summary>
        /// Frame per Second
        /// </summary>
        public const float FPS = 33.333333F;
        #endregion

        #region 내부 클래스
        public class GameParameter
        {
            #region 프로퍼티
            public string GameName { get; set; }
            public string GameVersion { get; set; }
            public float FOVNormal { get; set; }
            public float FOVAUG { get; set; }
            public float FOVPSG1 { get; set; }
            public D3DFORMAT AutoDepthStencilFormat { get; set; }
            public float ClippingPlaneNear { get; set; }
            public float ClippingPlaneFar { get; set; }
            #endregion
        }
        #endregion

        #region 열거형
        public enum Version
        {
            None,
            XOPS093,
            XOPS096,
            XOPS097T,
            XOPS097FT,
            XOPS0975T,

            XOPSOLT16,
            XOPSOLT17,
            XOPSOLT18,
            XOPSOLT18F,
            XOPSOLT18F2,
            XOPSOLT19,
            XOPSOLT19F,
            XOPSOLT19F2,
        }

        public enum ModelID
        {
            UNKNOWN = -1,
            UP0 = 0,
            LEG = 1,
            RUN01 = 2,
            RUN02 = 3,
            RUN03 = 4,
            RUN04 = 5,
            RUN05 = 6,
            RUN06 = 7,
            ARM01 = 8,
            ARM02 = 9,
            PSG1 = 10,
            MP5 = 11,
            BULLET = 12,
            M92F = 13,
            MAC10 = 14,
            P90 = 15,
            GLOCK18 = 16,
            WALK01 = 17,
            WALK02 = 18,
            WALK03 = 19,
            WALK04 = 20,
            DE = 21,
            AUG = 22,
            GRENADE = 23,
            AK47 = 24,
            MP5SD = 25,
            SKY = 26,
            ARM00 = 27,
            M249 = 28,
            M4 = 29,
            UMP = 30,
            UP1 = 31,
            CASE = 32,
            UP2 = 33,
            M1911 = 34,
            UP3 = 35,
            UP4 = 36,
            CAN = 37,
            UP5 = 38,
            PC = 39,
            PC2 = 40,
            PC3 = 41,
            PC_WIDE = 42,
            PC2_WIDE = 43,
            PC3_WIDE = 44,
            ISU = 45,
            DAN = 46,
            M1 = 57,
            FAMAS = 58,
            MK23 = 59,
            MK23SD = 60,
            CONE = 61,
            ADD_SMALLOBJECT = 62,
        }
        
        public enum TextureID
        {
            UNKNOWN = -1,
            NONE = 0,
            CHAR_DDS = 9,
            SCOPE_DDS = 10,
            PSG1 = 11,
            SMOKE_DDS = 12,
            MFLASH_DDS = 13,
            BLOOD_DDS = 14,
            YAKKYOU_DDS = 15,
            MP5 = 16,
            GLOCK18 = 17,
            BULLET = 18,
            M92F = 19,
            CHAR_DDS2 = 30,
            TITLE_DDS = 31,
            GRENADE = 32,
            AK47 = 33,
            MP5SD = 34,
            P90 = 36,
            M249 = 37,
            M4 = 38,
            UMP = 39,
            MAC10 = 40,
            CAN = 41,
            SKY1 = 42,
            CASE = 44,
            M1911 = 45,
            PC = 46,
            ISU = 47,
            GLOCK17 = 48,
            DAN = 49,
            DE = 50,
            AUG = 51,
            PC_SW = 52,
            PC_D = 53,
            M1 = 54,
            FAMAS = 55,
            MK23 = 56,
            CONE = 57,
            ADD_SMALLOBJECT = 58,
        }

        public enum D3DFORMAT
        {
            UNKNOWN = -1,
            D3DFMT_UNKNOWN = 0,
            D3DFMT_R8G8B8 = 20,
            D3DFMT_A8R8G8B8 = 21,
            D3DFMT_X8R8G8B8 = 22,
            D3DFMT_R5G6B5 = 23,
            D3DFMT_X1R5G5B5 = 24,
            D3DFMT_A1R5G5B5 = 25,
            D3DFMT_A4R4G4B4 = 26,
            D3DFMT_R3G3B2 = 27,
            D3DFMT_A8 = 28,
            D3DFMT_A8R3G3B2 = 29,
            D3DFMT_X4R4G4B4 = 30,
            D3DFMT_A2B10G10R10 = 31,
            D3DFMT_A8B8G8R8 = 32,
            D3DFMT_X8B8G8R8 = 33,
            D3DFMT_G16R16 = 34,
            D3DFMT_A2R10G10B10 = 35,
            D3DFMT_A16B16G16R16 = 36,
            D3DFMT_A8P8 = 40,
            D3DFMT_P8 = 41,
            D3DFMT_L8 = 50,
            D3DFMT_A8L8 = 51,
            D3DFMT_A4L4 = 52,
            D3DFMT_V8U8 = 60,
            D3DFMT_L6V5U5 = 61,
            D3DFMT_X8L8V8U8 = 62,
            D3DFMT_Q8W8V8U8 = 63,
            D3DFMT_V16U16 = 64,
            D3DFMT_A2W10V10U10 = 67,
            D3DFMT_D16_LOCKABLE = 70,
            D3DFMT_D32 = 71,
            D3DFMT_D15S1 = 73,
            D3DFMT_D24S8 = 75,
            D3DFMT_D24X8 = 77,
            D3DFMT_D24X4S4 = 79,
            D3DFMT_D16 = 80,
            D3DFMT_D32F_LOCKABLE = 82,
            D3DFMT_D24FS8 = 83,
            D3DFMT_L16 = 81,
            D3DFMT_VERTEXDATA = 100,
            D3DFMT_INDEX16 = 101,
            D3DFMT_INDEX32 = 102,
            D3DFMT_Q16W16V16U16 = 110,
            D3DFMT_R16F = 111,
            D3DFMT_G16R16F = 112,
            D3DFMT_A16B16G16R16F = 113,
            D3DFMT_R32F = 114,
            D3DFMT_G32R32F = 115,
            D3DFMT_A32B32G32R32F = 116,
            D3DFMT_CxV8U8 = 117,
        }
        #endregion

        #region 프로퍼티
        /// <summary>
        /// X Operations의 버전을 취득하거나 설정할 수 있습니다.
        /// </summary>
        public Version Ver { get; set; }

        /// <summary>
        /// X Operations의 게임 파라미터 정보를 취득하거나 설정할 수 있습니다.
        /// </summary>
        public GameParameter GameParam { get; set; }

        /// <summary>
        /// X Operations의 무기 데이터 정보를 취득하거나 설정할 수 있습니다.
        /// </summary>
        public Weapon Weapon { get; set; }

        /// <summary>
        /// X Operations의 캐릭터 데이터 정보를 취득하거나 설정할 수 있습니다.
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// X Operations의 소품 데이터 정보를 취득하거나 설정할 수 있습니다.
        /// </summary>
        public SmallObject SmallObject { get; set; }
        #endregion

        #region 생성자
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public XOperations()
        {
            Ver = Version.None;
            Weapon = null;
            Character = null;
            SmallObject = null;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        public XOperations(string filePath)
        {
            Ver = CheckVersion(filePath);
            Weapon = new Weapon(Ver, filePath);
            Character = new Character(Ver, filePath);
            SmallObject = new SmallObject(Ver, filePath);
            ReadGameParameter(filePath);
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        public XOperations(int processId)
        {
            Ver = CheckVersion(processId);
            Weapon = new Weapon(Ver, processId);
            Character = new Character(Ver, processId);
            SmallObject = new SmallObject(Ver, processId);
            ReadGameParameter(processId);
        }
        #endregion

        #region 메서드
        /// <summary>
        /// X Operations 실행 파일의 버전을 검사합니다.
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        /// <returns>버전</returns>
        public Version CheckVersion(string filePath)
        {
            // 반환 값
            Version rtnVer = Version.None;

            // 빈 경로인지 검사
            if (String.IsNullOrEmpty(filePath)) { return rtnVer; }

            // PE 헤더 읽기
            PeHeaderReader reader = new PeHeaderReader(filePath);

            // 32Bit 헤더 여부 검사
            if (reader.Is32BitHeader)
            {
                // Entry Point
                long EP = reader.OptionalHeader32.AddressOfEntryPoint;

                // EntryPoint에 따른 버전
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.None))) { return rtnVer; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS093))) { rtnVer = Version.XOPS093; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS096))) { rtnVer = Version.XOPS096; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS097T))) { rtnVer = Version.XOPS097T; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS097FT))) { rtnVer = Version.XOPS097FT; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS0975T))) { rtnVer = Version.XOPS0975T; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT16))) { rtnVer = Version.XOPSOLT16; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT17))) { rtnVer = Version.XOPSOLT17; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT18))) { rtnVer = Version.XOPSOLT18; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT18F))) { rtnVer = Version.XOPSOLT18F; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT18F2))) { rtnVer = Version.XOPSOLT18F2; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT19))) { rtnVer = Version.XOPSOLT19; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT19F))) { rtnVer = Version.XOPSOLT19F; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT19F2))) { rtnVer = Version.XOPSOLT19F2; }

                return rtnVer;
            }
            else { return rtnVer; }
        }

        /// <summary>
        /// X Operations 실행 파일의 버전을 검사합니다.
        /// </summary>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        /// <returns>버전</returns>
        public Version CheckVersion(int processId)
        {
            // 반환 값
            Version rtnVer = Version.None;

            // 프로세스 존재 여부
            if (Process.GetProcesses().Any(p => p.Id == processId) == false) { return rtnVer; }

            // PE 헤더 읽기
            PeHeaderReader reader = new PeHeaderReader(processId);

            // 32Bit 헤더 여부 검사
            if (reader.Is32BitHeader)
            {
                // Entry Point
                long EP = reader.OptionalHeader32.AddressOfEntryPoint;

                // EntryPoint에 따른 버전
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.None))) { return rtnVer; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS093))) { rtnVer = Version.XOPS093; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS096))) { rtnVer = Version.XOPS096; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS097T))) { rtnVer = Version.XOPS097T; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS097FT))) { rtnVer = Version.XOPS097FT; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPS0975T))) { rtnVer = Version.XOPS0975T; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT16))) { rtnVer = Version.XOPSOLT16; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT17))) { rtnVer = Version.XOPSOLT17; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT18))) { rtnVer = Version.XOPSOLT18; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT18F))) { rtnVer = Version.XOPSOLT18F; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT18F2))) { rtnVer = Version.XOPSOLT18F2; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT19))) { rtnVer = Version.XOPSOLT19; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT19F))) { rtnVer = Version.XOPSOLT19F; }
                if (long.Equals(EP, XOPSOffsetManager.GetEntryPoint(Version.XOPSOLT19F2))) { rtnVer = Version.XOPSOLT19F2; }

                return rtnVer;
            }
            else { return rtnVer; }
        }
        
        /// <summary>
        /// X Operations 실행 파일의 게임 정보를 읽어옵니다.
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool ReadGameParameter(string filePath)
        {
            // 빈 경로 실패
            if (string.IsNullOrEmpty(filePath)) { return false; }

            // 버전 검사
            if(Ver == Version.None || Ver == Version.XOPS093 || Ver == Version.XOPSOLT16 || Ver == Version.XOPSOLT17) { return false; }

            // '\0'를 만날 때까지 읽는 메서드
            Func<BinaryReader, string> ReadString = (BinaryReader reader) =>
            {
                string s = string.Empty;
                char c = char.MinValue;

                while((int)(c = reader.ReadChar()) != '\0') { s += c; }

                return s;
            };

            // 데이터 읽기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    // 게임의 이름
                    long GameNameOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_NAME);
                    if (GameNameOffset == -1) { return false; }

                    br.BaseStream.Position = GameNameOffset;
                    string gameName = ReadString(br);

                    // 게임의 버전
                    long GameVersionOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_VERSION);
                    if (GameVersionOffset == -1) { return false; }

                    br.BaseStream.Position = GameVersionOffset;
                    string gameVersion = ReadString(br);

                    // 시야각
                    long[] FOVOffset = { XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.NORMAL), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.AUG), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.PSG1) };
                    float[] FOV = new float[FOVOffset.Length];
                    for(int i = 0; i < FOVOffset.Length; i++)
                    {
                        if (FOVOffset[i] == -1) { return false; }

                        br.BaseStream.Position = FOVOffset[i];
                        FOV[i] = br.ReadSingle();
                    }

                    // 깊이 스텐실 포맷
                    long AutoDepthStencilFormatOffset = XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.AUTODEPTHSTENCILFORMAT);
                    if (AutoDepthStencilFormatOffset == -1) { return false; }

                    br.BaseStream.Position = AutoDepthStencilFormatOffset;
                    D3DFORMAT d3dFormat = (D3DFORMAT)br.ReadInt32();

                    // 클리핑 평면
                    long[] ClippingPlaneOffset = { XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANENEAR), XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANEFAR) };
                    float[] clippingPlane = new float[ClippingPlaneOffset.Length];
                    for (int i = 0; i < ClippingPlaneOffset.Length; i++)
                    {
                        if (ClippingPlaneOffset[i] == -1) { return false; }

                        br.BaseStream.Position = ClippingPlaneOffset[i];
                        clippingPlane[i] = br.ReadSingle();
                    }

                    // 할당
                    GameParam = new GameParameter
                    {
                        GameName = gameName,
                        GameVersion = gameVersion,
                        FOVNormal = FOV[0],
                        FOVAUG = FOV[1],
                        FOVPSG1 = FOV[2],
                        AutoDepthStencilFormat = d3dFormat,
                        ClippingPlaneNear = clippingPlane[0],
                        ClippingPlaneFar = clippingPlane[1],
                    };
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations 실행 파일의 게임 정보를 저장합니다.
        /// </summary>
        /// <param name="filePath">X Operations의 실행 파일 경로</param>
        /// <param name="mf">메인 폼</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool SaveGameParameter(string filePath, XME.MainForm mf)
        {
            // 빈 경로 실패
            if (string.IsNullOrEmpty(filePath)) { return false; }

            // 버전 검사
            if (Ver == Version.None || Ver == Version.XOPS093 || Ver == Version.XOPSOLT16 || Ver == Version.XOPSOLT17) { return false; }

            // 데이터 쓰기
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // 게임의 이름
                    long GameNameOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_NAME);
                    if (GameNameOffset == -1) { return false; }

                    bw.BaseStream.Position = GameNameOffset;
                    for (int i = 0; i < mf.tBox_GameName.MaxLength; i++) { bw.Write((byte)0x00); }

                    bw.BaseStream.Position = GameNameOffset;
                    if (GameParam.GameName.Length > mf.tBox_GameName.MaxLength)
                    {
                        string gameName = GameParam.GameName.Substring(0, mf.tBox_GameName.MaxLength);
                        bw.Write(Encoding.ASCII.GetBytes(gameName));
                    }
                    else
                    {
                        bw.Write(Encoding.ASCII.GetBytes(GameParam.GameName));
                    }

                    // 게임의 버전
                    long GameVersionOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_VERSION);
                    if (GameVersionOffset == -1) { return false; }

                    bw.BaseStream.Position = GameVersionOffset;
                    for (int i = 0; i < mf.tBox_GameVersion.MaxLength; i++) { bw.Write((byte)0x00); }

                    bw.BaseStream.Position = GameVersionOffset;
                    if (GameParam.GameVersion.Length > mf.tBox_GameVersion.MaxLength)
                    {
                        string gameVersion = GameParam.GameVersion.Substring(0, mf.tBox_GameVersion.MaxLength);
                        bw.Write(Encoding.ASCII.GetBytes(gameVersion));
                    }
                    else
                    {
                        bw.Write(Encoding.ASCII.GetBytes(GameParam.GameVersion));
                    }

                    // 시야각
                    long[] FOVOffset = { XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.NORMAL), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.AUG), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.PSG1) };
                    float[] FOV = { GameParam.FOVNormal, GameParam.FOVAUG, GameParam.FOVPSG1 };
                    for (int i = 0; i < FOVOffset.Length; i++)
                    {
                        if (FOVOffset[i] == -1) { return false; }
                        bw.BaseStream.Position = FOVOffset[i];
                        bw.Write(FOV[i]);
                    }

                    // 깊이 스텐실 포맷
                    long AutoDepthStencilFormatOffset = XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.AUTODEPTHSTENCILFORMAT);
                    if (AutoDepthStencilFormatOffset == -1) { return false; }

                    bw.BaseStream.Position = AutoDepthStencilFormatOffset;
                    bw.Write((int)GameParam.AutoDepthStencilFormat);

                    // 클리핑 평면
                    long[] ClippingPlaneOffset = { XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANENEAR), XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANEFAR) };
                    float[] clippingPlane = { GameParam.ClippingPlaneNear, GameParam.ClippingPlaneFar };
                    for (int i = 0; i < ClippingPlaneOffset.Length; i++)
                    {
                        if (ClippingPlaneOffset[i] == -1) { return false; }

                        bw.BaseStream.Position = ClippingPlaneOffset[i];
                        bw.Write(clippingPlane[i]);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// X Operations 실행 파일의 게임 정보를 읽어옵니다.
        /// </summary>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool ReadGameParameter(int processId)
        {
            // 프로세스 존재 여부
            if (Process.GetProcesses().Any(p => p.Id == processId) == false) { return false; }

            // 버전 검사
            if (Ver == Version.None || Ver == Version.XOPS093 || Ver == Version.XOPSOLT16 || Ver == Version.XOPSOLT17) { return false; }

            // 데이터 읽기
            {
                WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

                // 게임의 이름
                long GameNameOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_NAME);
                if (GameNameOffset == -1) { return false; }

                pmm.ReadMemoryString((int)GameNameOffset, new IntPtr(0x400000), out string gameName, out int bytesRead);

                // 게임의 버전
                long GameVersionOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_VERSION);
                if (GameVersionOffset == -1) { return false; }

                pmm.ReadMemoryString((int)GameVersionOffset, new IntPtr(0x400000), out string gameVersion, out int bytesRead2);

                // 시야각
                long[] FOVOffset = { XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.NORMAL), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.AUG), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.PSG1) };
                float[] FOV = new float[FOVOffset.Length];
                for (int i = 0; i < FOVOffset.Length; i++)
                {
                    if (FOVOffset[i] == -1) { return false; }

                    pmm.ReadMemory<float>((int)FOVOffset[i], new IntPtr(0x400000), out byte[] data, out int bytesRead3);
                    FOV[i] = BitConverter.ToSingle(data, 0);
                }

                // 깊이 스텐실 포맷
                long AutoDepthStencilFormatOffset = XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.AUTODEPTHSTENCILFORMAT);
                if (AutoDepthStencilFormatOffset == -1) { return false; }

                pmm.ReadMemory<int>((int)AutoDepthStencilFormatOffset, new IntPtr(0x400000), out byte[] data2, out int bytesRead4);
                D3DFORMAT d3dFormat = (D3DFORMAT)BitConverter.ToInt32(data2, 0);

                // 클리핑 평면
                long[] ClippingPlaneOffset = { XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANENEAR), XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANEFAR) };
                float[] clippingPlane = new float[ClippingPlaneOffset.Length];
                for (int i = 0; i < ClippingPlaneOffset.Length; i++)
                {
                    if (ClippingPlaneOffset[i] == -1) { return false; }

                    pmm.ReadMemory<float>((int)ClippingPlaneOffset[i], new IntPtr(0x400000), out byte[] data3, out int bytesRead5);
                    clippingPlane[i] = BitConverter.ToSingle(data3, 0);
                }

                // 할당
                GameParam = new GameParameter
                {
                    GameName = gameName,
                    GameVersion = gameVersion,
                    FOVNormal = FOV[0],
                    FOVAUG = FOV[1],
                    FOVPSG1 = FOV[2],
                    AutoDepthStencilFormat = d3dFormat,
                    ClippingPlaneNear = clippingPlane[0],
                    ClippingPlaneFar = clippingPlane[1],
                };
            }

            return true;
        }

        /// <summary>
        /// X Operations 실행 파일의 게임 정보를 작성합니다.
        /// </summary>
        /// <param name="processId">X Operations의 프로세스 식별 번호</param>
        /// <param name="mf">메인 폼</param>
        /// <returns>성공(True), 실패(False)</returns>
        public bool WriteGameParameter(int processId, XME.MainForm mf)
        {
            // 프로세스 존재 여부
            if (Process.GetProcesses().Any(p => p.Id == processId) == false) { return false; }

            // 버전 검사
            if (Ver == Version.None || Ver == Version.XOPS093 || Ver == Version.XOPSOLT16 || Ver == Version.XOPSOLT17) { return false; }

            // 데이터 쓰기
            {
                WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

                // 게임의 이름
                long GameNameOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_NAME);
                if (GameNameOffset == -1) { return false; }

                string gameName = GameParam.GameName.Substring(0, mf.tBox_GameName.MaxLength);

                pmm.WriteMemory((int)GameNameOffset, new IntPtr(0x400000), Encoding.ASCII.GetBytes(gameName), out int bytesWritten);

                // 게임의 버전
                long GameVersionOffset = XOPSOffsetManager.GetGameStringOffset(Ver, XOPSOffsetManager.GameStringType.GAME_VERSION);
                if (GameVersionOffset == -1) { return false; }

                string gameVersion = GameParam.GameVersion.Substring(0, mf.tBox_GameVersion.MaxLength);

                pmm.WriteMemory((int)GameVersionOffset, new IntPtr(0x400000), Encoding.ASCII.GetBytes(gameVersion), out bytesWritten);

                // 시야각
                long[] FOVOffset = { XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.NORMAL), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.AUG), XOPSOffsetManager.GetFovOffset(Ver, XOPSOffsetManager.FOVType.PSG1) };
                float[] FOV = { GameParam.FOVNormal, GameParam.FOVAUG, GameParam.FOVPSG1 };
                for (int i = 0; i < FOVOffset.Length; i++)
                {
                    if (FOVOffset[i] == -1) { return false; }

                    pmm.WriteMemory((int)FOVOffset[i], new IntPtr(0x400000), BitConverter.GetBytes(FOV[i]), out bytesWritten);
                }

                // 깊이 스텐실 포맷
                long AutoDepthStencilFormatOffset = XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.AUTODEPTHSTENCILFORMAT);
                if (AutoDepthStencilFormatOffset == -1) { return false; }

                pmm.WriteMemory((int)AutoDepthStencilFormatOffset, new IntPtr(0x400000), BitConverter.GetBytes((int)GameParam.AutoDepthStencilFormat), out bytesWritten);

                // 클리핑 평면
                long[] ClippingPlaneOffset = { XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANENEAR), XOPSOffsetManager.GetDirectXOffset(Ver, XOPSOffsetManager.DirectXType.CLIPPINGPLANEFAR) };
                float[] clippingPlane = { GameParam.ClippingPlaneNear, GameParam.ClippingPlaneFar };
                for (int i = 0; i < ClippingPlaneOffset.Length; i++)
                {
                    if (ClippingPlaneOffset[i] == -1) { return false; }

                    pmm.WriteMemory((int)ClippingPlaneOffset[i], new IntPtr(0x400000), BitConverter.GetBytes(clippingPlane[i]), out bytesWritten);
                }
            }

            return true;
        }
        #endregion
    }
}
