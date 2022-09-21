using System;
using System.IO;

namespace XOPS
{
    /// <summary>
    /// 오프셋 관리 클래스
    /// </summary>
    public class XOPSOffsetManager
    {
        #region 열거형
        /// <summary>
        /// 시야 유형
        /// </summary>
        public enum FOVType
        {
            NORMAL,
            AUG,
            PSG1,
        }

        /// <summary>
        /// DirectX 유형
        /// </summary>
        public enum DirectXType
        {
            AUTODEPTHSTENCILFORMAT,
            CLIPPINGPLANENEAR,
            CLIPPINGPLANEFAR,
        }

        /// <summary>
        /// 게임 문자열 유형
        /// </summary>
        public enum GameStringType
        {
            GAME_NAME,
            GAME_VERSION,
        }
        #endregion

        #region 메서드
        /// <summary>
        /// 버전에 따른 EntryPoint를 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <returns>성공(Entry Point Offset), 실패(-1)</returns>
        public static long GetEntryPoint(XOperations.Version version)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;                              // Not Supported
                case XOperations.Version.XOPS093: { rtnOffset = -1/*0x4AAEF*/; } break;                // Not Supported
                case XOperations.Version.XOPS096: { rtnOffset = 0x4FCD8; } break;
                case XOperations.Version.XOPS097T: { rtnOffset = 0x505D8; } break;
                case XOperations.Version.XOPS097FT: { rtnOffset = 0x50698; } break;
                case XOperations.Version.XOPS0975T: { rtnOffset = 0x543B3; } break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1/*0x54F26*/; } break;              // Not Supported
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT18: { rtnOffset = 0x57348; } break;
                case XOperations.Version.XOPSOLT18F: { rtnOffset = 0x57648; } break;
                case XOperations.Version.XOPSOLT18F2: { rtnOffset = 0x57F48; } break;
                case XOperations.Version.XOPSOLT19: { rtnOffset = 0x588C8; } break;
                case XOperations.Version.XOPSOLT19F: { rtnOffset = 0x5D57A; } break;
                case XOperations.Version.XOPSOLT19F2: { rtnOffset = 0x5D5BA; } break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 XOPS의 무기 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetWeaponOffset(XOperations.Version version)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;                              // Not Supported
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;                           // Not Supported
                case XOperations.Version.XOPS096: { rtnOffset = 0x5D32C; } break;
                case XOperations.Version.XOPS097T: case XOperations.Version.XOPS097FT: { rtnOffset = 0x5E32C; } break;
                case XOperations.Version.XOPS0975T: { rtnOffset = 0x77FB0; } break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT18: { rtnOffset = 0x6540C; } break;
                case XOperations.Version.XOPSOLT18F: { rtnOffset = 0x6540C; } break;
                case XOperations.Version.XOPSOLT18F2: { rtnOffset = 0x6640C; } break;
                case XOperations.Version.XOPSOLT19: { rtnOffset = 0x6641C; } break;
                case XOperations.Version.XOPSOLT19F: { rtnOffset = 0x777E8; } break;
                case XOperations.Version.XOPSOLT19F2: { rtnOffset = 0x777E8; } break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 XOPS의 캐릭터 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetCharacterOffset(XOperations.Version version)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;                              // Not Supported
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;                           // Not Supported
                case XOperations.Version.XOPS096: { rtnOffset = 0x5D864; } break;
                case XOperations.Version.XOPS097T: case XOperations.Version.XOPS097FT: { rtnOffset = 0x5E864; } break;
                case XOperations.Version.XOPS0975T: { rtnOffset = 0x784E8; } break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT18: { rtnOffset = 0x65944; } break;
                case XOperations.Version.XOPSOLT18F: { rtnOffset = 0x65944; } break;
                case XOperations.Version.XOPSOLT18F2: { rtnOffset = 0x66944; } break;
                case XOperations.Version.XOPSOLT19: { rtnOffset = 0x66954; } break;
                case XOperations.Version.XOPSOLT19F: { rtnOffset = 0x77D20; } break;
                case XOperations.Version.XOPSOLT19F2: { rtnOffset = 0x77D20; } break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 XOPS의 소품 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetSmallObjectOffset(XOperations.Version version)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;                              // Not Supported
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;                           // Not Supported
                case XOperations.Version.XOPS096: { rtnOffset = 0x65E73; } break;
                case XOperations.Version.XOPS097T: case XOperations.Version.XOPS097FT: { rtnOffset = 0x66E73; } break;
                case XOperations.Version.XOPS0975T: { rtnOffset = 0x846E7; } break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;                         // Not Supported
                case XOperations.Version.XOPSOLT18: { rtnOffset = 0x65BB3; } break;
                case XOperations.Version.XOPSOLT18F: { rtnOffset = 0x65BB3; } break;
                case XOperations.Version.XOPSOLT18F2: { rtnOffset = 0x66BB3; } break;
                case XOperations.Version.XOPSOLT19: { rtnOffset = 0x66BC3; } break;
                case XOperations.Version.XOPSOLT19F: { rtnOffset = 0x77F8F; } break;
                case XOperations.Version.XOPSOLT19F2: { rtnOffset = 0x77F8F; } break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 무기별 이름 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <param name="id">무기 식별 번호</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetWeaponNameOffset(XOperations.Version version, Weapon.WeaponID id)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;                              // Not Supported
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;                           // Not Supported
                case XOperations.Version.XOPS096:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x66344; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x66334; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x66324; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x66314; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x66304; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x662F4; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x662E4; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x662D4; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x662C4; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x662B4; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x662A4; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x66294; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x66284; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x66274; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x66264; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x66254; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x66244; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x66234; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x66224; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x66214; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x66204; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x661F4; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x661E4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS097T:
                case XOperations.Version.XOPS097FT:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x67344; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x67334; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x67324; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x67314; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x67304; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x672F4; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x672E4; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x672D4; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x672C4; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x672B4; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x672A4; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x67294; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x67284; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x67274; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x67264; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x67254; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x67244; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x67234; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x67224; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x67214; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x67204; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x671F4; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x671E4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS0975T:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x792A0; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x79290; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x79280; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x79270; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x79260; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x79250; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x79240; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x79230; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x79220; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x79210; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x79200; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x791F0; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x791E0; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x791D0; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x791C0; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x791B0; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x791A0; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x79190; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x79180; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x79170; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x79160; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x79150; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x79140; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT18:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x6E08C; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x6E07C; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x6E06C; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x6E05C; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x6E04C; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x6E03C; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x6E02C; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x6E01C; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x6E00C; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x6DFFC; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x6DFEC; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x6DFDC; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x6DFCC; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x6DFBC; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x6DFAC; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x6DF9C; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x6DF8C; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x6DF7C; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x6DF6C; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x6DF5C; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x6DF4C; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x6DF3C; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x6DF2C; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT18F:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x6E0B0; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x6E0A0; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x6E090; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x6E080; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x6E070; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x6E060; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x6E050; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x6E040; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x6E030; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x6E020; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x6E010; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x6E000; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x6DFF0; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x6DFE0; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x6DFD0; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x6DFC0; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x6DFB0; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x6DFA0; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x6DF90; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x6DF80; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x6DF70; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x6DF60; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x6DF50; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT18F2:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x6F0E4; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x6F0D4; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x6F0C4; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x6F0B4; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x6F0A4; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x6F094; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x6F084; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x6F074; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x6F064; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x6F054; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x6F044; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x6F034; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x6F024; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x6F014; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x6F004; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x6EFF4; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x6EFE4; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x6EFD4; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x6EFC4; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x6EFB4; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x6EFA4; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x6EF94; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x6EF84; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x6F130; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x6F120; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x6F110; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x6F100; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x6F0F0; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x6F0E0; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x6F0D0; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x6F0C0; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x6F0B0; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x6F0A0; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x6F090; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x6F080; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x6F070; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x6F060; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x6F050; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x6F040; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x6F030; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x6F020; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x6F010; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x6F000; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x6EFF0; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x6EFE0; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x6EFD0; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19F:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x774D0; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x774E0; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x774D0; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x774C0; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x774B0; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x774A0; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x77490; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x77480; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x77470; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x77460; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x77450; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x77440; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x77430; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x77420; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x77410; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x77400; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x773F0; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x773E0; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x773D0; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x773C0; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x773B0; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x773A0; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x77390; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19F2:
                    {
                        switch (id)
                        {
                            case Weapon.WeaponID.NONE: { rtnOffset = 0x774D0; } break;
                            case Weapon.WeaponID.MP5: { rtnOffset = 0x774E0; } break;
                            case Weapon.WeaponID.PSG1: { rtnOffset = 0x774D0; } break;
                            case Weapon.WeaponID.M92F: { rtnOffset = 0x774C0; } break;
                            case Weapon.WeaponID.GLOCK18_SEMI: { rtnOffset = 0x774B0; } break;
                            case Weapon.WeaponID.DE: { rtnOffset = 0x774A0; } break;
                            case Weapon.WeaponID.MAC10: { rtnOffset = 0x77490; } break;
                            case Weapon.WeaponID.UMP: { rtnOffset = 0x77480; } break;
                            case Weapon.WeaponID.P90: { rtnOffset = 0x77470; } break;
                            case Weapon.WeaponID.M4: { rtnOffset = 0x77460; } break;
                            case Weapon.WeaponID.AK47: { rtnOffset = 0x77450; } break;
                            case Weapon.WeaponID.AUG: { rtnOffset = 0x77440; } break;
                            case Weapon.WeaponID.M249: { rtnOffset = 0x77430; } break;
                            case Weapon.WeaponID.GRENADE: { rtnOffset = 0x77420; } break;
                            case Weapon.WeaponID.MP5SD: { rtnOffset = 0x77410; } break;
                            case Weapon.WeaponID.CASE: { rtnOffset = 0x77400; } break;
                            case Weapon.WeaponID.GLOCK18_FULL: { rtnOffset = 0x773F0; } break;
                            case Weapon.WeaponID.M1911: { rtnOffset = 0x773E0; } break;
                            case Weapon.WeaponID.GLOCK17: { rtnOffset = 0x773D0; } break;
                            case Weapon.WeaponID.M1: { rtnOffset = 0x773C0; } break;
                            case Weapon.WeaponID.FAMAS: { rtnOffset = 0x773B0; } break;
                            case Weapon.WeaponID.MK23: { rtnOffset = 0x773A0; } break;
                            case Weapon.WeaponID.MK23SD: { rtnOffset = 0x77390; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 텍스쳐 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <param name="id">텍스쳐의 식별 번호</param>
        /// <returns>성공(Offset), 실패(-1), 생략(-2)</returns>
        public static long GetTextureOffset(XOperations.Version version, XOperations.TextureID id)
        {
            long rtnOffset = -1;

            switch(version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS096:
                    {
                        switch (id)
                        {
                                case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                                case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                                case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x6550C; } break;
                                case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x654F8; } break;
                                case XOperations.TextureID.PSG1: { rtnOffset = 0x654D8; } break;
                                case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x654C4; } break;
                                case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x654B0; } break;
                                case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x65459; } break;
                                case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x65488; } break;
                                case XOperations.TextureID.MP5: { rtnOffset = 0x6546C; } break;
                                case XOperations.TextureID.GLOCK18: { rtnOffset = 0x6544C; } break;
                                case XOperations.TextureID.BULLET: { rtnOffset = 0x65434; } break;
                                case XOperations.TextureID.M92F: { rtnOffset = 0x65414; } break;
                                case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x65400; } break;
                                case XOperations.TextureID.GRENADE: { rtnOffset = 0x653E0; } break;
                                case XOperations.TextureID.AK47: { rtnOffset = 0x653C0; } break;
                                case XOperations.TextureID.MP5SD: { rtnOffset = 0x653A0; } break;
                                case XOperations.TextureID.P90: { rtnOffset = 0x65384; } break;
                                case XOperations.TextureID.M249: { rtnOffset = 0x65364; } break;
                                case XOperations.TextureID.M4: { rtnOffset = 0x65348; } break;
                                case XOperations.TextureID.UMP: { rtnOffset = 0x6532C; } break;
                                case XOperations.TextureID.MAC10: { rtnOffset = 0x6530C; } break;
                                case XOperations.TextureID.CAN: { rtnOffset = 0x652F4; } break;
                                case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                                case XOperations.TextureID.CASE: { rtnOffset = 0x652D4; } break;
                                case XOperations.TextureID.M1911: { rtnOffset = 0x652B8; } break;
                                case XOperations.TextureID.PC: { rtnOffset = 0x652A0; } break;
                                case XOperations.TextureID.ISU: { rtnOffset = 0x65288; } break;
                                case XOperations.TextureID.GLOCK17: { rtnOffset = 0x65268; } break;
                                case XOperations.TextureID.DAN: { rtnOffset = 0x65250; } break;
                                case XOperations.TextureID.DE: { rtnOffset = 0x65234; } break;
                                case XOperations.TextureID.AUG: { rtnOffset = 0x65218; } break;
                                case XOperations.TextureID.PC_SW: { rtnOffset = 0x651FC; } break;
                                case XOperations.TextureID.PC_D: { rtnOffset = 0x651E4; } break;
                                case XOperations.TextureID.M1: { rtnOffset = 0x651C8; } break;
                                case XOperations.TextureID.FAMAS: { rtnOffset = 0x651A8; } break;
                                case XOperations.TextureID.MK23: { rtnOffset = 0x65188; } break;
                                case XOperations.TextureID.CONE: { rtnOffset = 0x65170; } break;
                                case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                                default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPS097T:
                case XOperations.Version.XOPS097FT:
                    {
                        switch (id)
                        {
                            case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x6650C; } break;
                            case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x664F8; } break;
                            case XOperations.TextureID.PSG1: { rtnOffset = 0x664D8; } break;
                            case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x664C4; } break;
                            case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x664B0; } break;
                            case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x66459; } break;
                            case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x66488; } break;
                            case XOperations.TextureID.MP5: { rtnOffset = 0x6646C; } break;
                            case XOperations.TextureID.GLOCK18: { rtnOffset = 0x6644C; } break;
                            case XOperations.TextureID.BULLET: { rtnOffset = 0x66434; } break;
                            case XOperations.TextureID.M92F: { rtnOffset = 0x66414; } break;
                            case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x66400; } break;
                            case XOperations.TextureID.GRENADE: { rtnOffset = 0x663E0; } break;
                            case XOperations.TextureID.AK47: { rtnOffset = 0x663C0; } break;
                            case XOperations.TextureID.MP5SD: { rtnOffset = 0x663A0; } break;
                            case XOperations.TextureID.P90: { rtnOffset = 0x66384; } break;
                            case XOperations.TextureID.M249: { rtnOffset = 0x66364; } break;
                            case XOperations.TextureID.M4: { rtnOffset = 0x66348; } break;
                            case XOperations.TextureID.UMP: { rtnOffset = 0x6632C; } break;
                            case XOperations.TextureID.MAC10: { rtnOffset = 0x6630C; } break;
                            case XOperations.TextureID.CAN: { rtnOffset = 0x662F4; } break;
                            case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CASE: { rtnOffset = 0x662D4; } break;
                            case XOperations.TextureID.M1911: { rtnOffset = 0x662B8; } break;
                            case XOperations.TextureID.PC: { rtnOffset = 0x662A0; } break;
                            case XOperations.TextureID.ISU: { rtnOffset = 0x66288; } break;
                            case XOperations.TextureID.GLOCK17: { rtnOffset = 0x66268; } break;
                            case XOperations.TextureID.DAN: { rtnOffset = 0x66250; } break;
                            case XOperations.TextureID.DE: { rtnOffset = 0x66234; } break;
                            case XOperations.TextureID.AUG: { rtnOffset = 0x66218; } break;
                            case XOperations.TextureID.PC_SW: { rtnOffset = 0x661FC; } break;
                            case XOperations.TextureID.PC_D: { rtnOffset = 0x661E4; } break;
                            case XOperations.TextureID.M1: { rtnOffset = 0x661C8; } break;
                            case XOperations.TextureID.FAMAS: { rtnOffset = 0x661A8; } break;
                            case XOperations.TextureID.MK23: { rtnOffset = 0x66188; } break;
                            case XOperations.TextureID.CONE: { rtnOffset = 0x66170; } break;
                            case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPS0975T:
                    {
                        switch (id)
                        {
                            case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x78BEC; } break;
                            case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x78B90; } break;
                            case XOperations.TextureID.PSG1: { rtnOffset = 0x78B70; } break;
                            case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x78B5C; } break;
                            case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x78B48; } break;
                            case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x78B34; } break;
                            case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x78B20; } break;
                            case XOperations.TextureID.MP5: { rtnOffset = 0x78B04; } break;
                            case XOperations.TextureID.GLOCK18: { rtnOffset = 0x78AE4; } break;
                            case XOperations.TextureID.BULLET: { rtnOffset = 0x78ACC; } break;
                            case XOperations.TextureID.M92F: { rtnOffset = 0x78AAC; } break;
                            case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x78A98; } break;
                            case XOperations.TextureID.GRENADE: { rtnOffset = 0x78A78; } break;
                            case XOperations.TextureID.AK47: { rtnOffset = 0x78A58; } break;
                            case XOperations.TextureID.MP5SD: { rtnOffset = 0x78A38; } break;
                            case XOperations.TextureID.P90: { rtnOffset = 0x78A1C; } break;
                            case XOperations.TextureID.M249: { rtnOffset = 0x789FC; } break;
                            case XOperations.TextureID.M4: { rtnOffset = 0x789E0; } break;
                            case XOperations.TextureID.UMP: { rtnOffset = 0x789C4; } break;
                            case XOperations.TextureID.MAC10: { rtnOffset = 0x789A4; } break;
                            case XOperations.TextureID.CAN: { rtnOffset = 0x7898C; } break;
                            case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CASE: { rtnOffset = 0x7896C; } break;
                            case XOperations.TextureID.M1911: { rtnOffset = 0x78950; } break;
                            case XOperations.TextureID.PC: { rtnOffset = 0x78938; } break;
                            case XOperations.TextureID.ISU: { rtnOffset = 0x78920; } break;
                            case XOperations.TextureID.GLOCK17: { rtnOffset = 0x78900; } break;
                            case XOperations.TextureID.DAN: { rtnOffset = 0x788E8; } break;
                            case XOperations.TextureID.DE: { rtnOffset = 0x788CC; } break;
                            case XOperations.TextureID.AUG: { rtnOffset = 0x788B0; } break;
                            case XOperations.TextureID.PC_SW: { rtnOffset = 0x78894; } break;
                            case XOperations.TextureID.PC_D: { rtnOffset = 0x7887C; } break;
                            case XOperations.TextureID.M1: { rtnOffset = 0x78860; } break;
                            case XOperations.TextureID.FAMAS: { rtnOffset = 0x78840; } break;
                            case XOperations.TextureID.MK23: { rtnOffset = 0x78820; } break;
                            case XOperations.TextureID.CONE: { rtnOffset = 0x78808; } break;
                            case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;

                case XOperations.Version.XOPSOLT16:
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT18:
                case XOperations.Version.XOPSOLT18F:
                    {
                        switch (id)
                        {
                            case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x6D778; } break;
                            case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x6D764; } break;
                            case XOperations.TextureID.PSG1: { rtnOffset = 0x6D744; } break;
                            case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x6D730; } break;
                            case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x6D71C; } break;
                            case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x6D708; } break;
                            case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x6D6F4; } break;
                            case XOperations.TextureID.MP5: { rtnOffset = 0x6D6D8; } break;
                            case XOperations.TextureID.GLOCK18: { rtnOffset = 0x6D6B8; } break;
                            case XOperations.TextureID.BULLET: { rtnOffset = 0x6D6A0; } break;
                            case XOperations.TextureID.M92F: { rtnOffset = 0x6D680; } break;
                            case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x6D66C; } break;
                            case XOperations.TextureID.GRENADE: { rtnOffset = 0x6D64C; } break;
                            case XOperations.TextureID.AK47: { rtnOffset = 0x6D62C; } break;
                            case XOperations.TextureID.MP5SD: { rtnOffset = 0x6D60c; } break;
                            case XOperations.TextureID.P90: { rtnOffset = 0x6D5F0; } break;
                            case XOperations.TextureID.M249: { rtnOffset = 0x6D5D0; } break;
                            case XOperations.TextureID.M4: { rtnOffset = 0x6D5B4; } break;
                            case XOperations.TextureID.UMP: { rtnOffset = 0x6D598; } break;
                            case XOperations.TextureID.MAC10: { rtnOffset = 0x6D578; } break;
                            case XOperations.TextureID.CAN: { rtnOffset = 0x6D560; } break;
                            case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CASE: { rtnOffset = 0x6D540; } break;
                            case XOperations.TextureID.M1911: { rtnOffset = 0x6D524; } break;
                            case XOperations.TextureID.PC: { rtnOffset = 0x6D50C; } break;
                            case XOperations.TextureID.ISU: { rtnOffset = 0x6D4F4; } break;
                            case XOperations.TextureID.GLOCK17: { rtnOffset = 0x6D4D4; } break;
                            case XOperations.TextureID.DAN: { rtnOffset = 0x6D4BC; } break;
                            case XOperations.TextureID.DE: { rtnOffset = 0x6D4A0; } break;
                            case XOperations.TextureID.AUG: { rtnOffset = 0x6D484; } break;
                            case XOperations.TextureID.PC_SW: { rtnOffset = 0x6D468; } break;
                            case XOperations.TextureID.PC_D: { rtnOffset = 0x6D450; } break;
                            case XOperations.TextureID.M1: { rtnOffset = 0x6D434; } break;
                            case XOperations.TextureID.FAMAS: { rtnOffset = 0x6D414; } break;
                            case XOperations.TextureID.MK23: { rtnOffset = 0x6D3F4; } break;
                            case XOperations.TextureID.CONE: { rtnOffset = 0x6D3DC; } break;
                            case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT18F2:
                    {
                        switch (id)
                        {
                            case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x6E7AC; } break;
                            case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x6E798; } break;
                            case XOperations.TextureID.PSG1: { rtnOffset = 0x6E778; } break;
                            case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x6E764; } break;
                            case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x6E750; } break;
                            case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x6E73C; } break;
                            case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x6E728; } break;
                            case XOperations.TextureID.MP5: { rtnOffset = 0x6E70C; } break;
                            case XOperations.TextureID.GLOCK18: { rtnOffset = 0x6E6EC; } break;
                            case XOperations.TextureID.BULLET: { rtnOffset = 0x6E6D4; } break;
                            case XOperations.TextureID.M92F: { rtnOffset = 0x6E6B4; } break;
                            case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x6E6A0; } break;
                            case XOperations.TextureID.GRENADE: { rtnOffset = 0x6E680; } break;
                            case XOperations.TextureID.AK47: { rtnOffset = 0x6E660; } break;
                            case XOperations.TextureID.MP5SD: { rtnOffset = 0x6E640; } break;
                            case XOperations.TextureID.P90: { rtnOffset = 0x6E624; } break;
                            case XOperations.TextureID.M249: { rtnOffset = 0x6E604; } break;
                            case XOperations.TextureID.M4: { rtnOffset = 0x6E5E8; } break;
                            case XOperations.TextureID.UMP: { rtnOffset = 0x6E5CC; } break;
                            case XOperations.TextureID.MAC10: { rtnOffset = 0x6E5AC; } break;
                            case XOperations.TextureID.CAN: { rtnOffset = 0x6E594; } break;
                            case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CASE: { rtnOffset = 0x6E574; } break;
                            case XOperations.TextureID.M1911: { rtnOffset = 0x6E558; } break;
                            case XOperations.TextureID.PC: { rtnOffset = 0x6E540; } break;
                            case XOperations.TextureID.ISU: { rtnOffset = 0x6E528; } break;
                            case XOperations.TextureID.GLOCK17: { rtnOffset = 0x6E508; } break;
                            case XOperations.TextureID.DAN: { rtnOffset = 0x6E4F0; } break;
                            case XOperations.TextureID.DE: { rtnOffset = 0x6E4D4; } break;
                            case XOperations.TextureID.AUG: { rtnOffset = 0x6E4B8; } break;
                            case XOperations.TextureID.PC_SW: { rtnOffset = 0x6E49C; } break;
                            case XOperations.TextureID.PC_D: { rtnOffset = 0x6E484; } break;
                            case XOperations.TextureID.M1: { rtnOffset = 0x6E468; } break;
                            case XOperations.TextureID.FAMAS: { rtnOffset = 0x6E448; } break;
                            case XOperations.TextureID.MK23: { rtnOffset = 0x6E428; } break;
                            case XOperations.TextureID.CONE: { rtnOffset = 0x6E410; } break;
                            case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT19:
                    {
                        switch (id)
                        {
                            case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x6E7E8; } break;
                            case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x6E7D4; } break;
                            case XOperations.TextureID.PSG1: { rtnOffset = 0x6E7B4; } break;
                            case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x6E7A0; } break;
                            case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x6E78C; } break;
                            case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x6E778; } break;
                            case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x6E764; } break;
                            case XOperations.TextureID.MP5: { rtnOffset = 0x6E748; } break;
                            case XOperations.TextureID.GLOCK18: { rtnOffset = 0x6E728; } break;
                            case XOperations.TextureID.BULLET: { rtnOffset = 0x6E710; } break;
                            case XOperations.TextureID.M92F: { rtnOffset = 0x6E6F0; } break;
                            case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x6E6DC; } break;
                            case XOperations.TextureID.GRENADE: { rtnOffset = 0x6E6BC; } break;
                            case XOperations.TextureID.AK47: { rtnOffset = 0x6E69C; } break;
                            case XOperations.TextureID.MP5SD: { rtnOffset = 0x6E67C; } break;
                            case XOperations.TextureID.P90: { rtnOffset = 0x6E660; } break;
                            case XOperations.TextureID.M249: { rtnOffset = 0x6E640; } break;
                            case XOperations.TextureID.M4: { rtnOffset = 0x6E624; } break;
                            case XOperations.TextureID.UMP: { rtnOffset = 0x6E608; } break;
                            case XOperations.TextureID.MAC10: { rtnOffset = 0x6E5E8; } break;
                            case XOperations.TextureID.CAN: { rtnOffset = 0x6E5D0; } break;
                            case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CASE: { rtnOffset = 0x6E5B0; } break;
                            case XOperations.TextureID.M1911: { rtnOffset = 0x6E594; } break;
                            case XOperations.TextureID.PC: { rtnOffset = 0x6E57C; } break;
                            case XOperations.TextureID.ISU: { rtnOffset = 0x6E564; } break;
                            case XOperations.TextureID.GLOCK17: { rtnOffset = 0x6E544; } break;
                            case XOperations.TextureID.DAN: { rtnOffset = 0x6E52C; } break;
                            case XOperations.TextureID.DE: { rtnOffset = 0x6E510; } break;
                            case XOperations.TextureID.AUG: { rtnOffset = 0x6E4F4; } break;
                            case XOperations.TextureID.PC_SW: { rtnOffset = 0x6E4D8; } break;
                            case XOperations.TextureID.PC_D: { rtnOffset = 0x6E4C0; } break;
                            case XOperations.TextureID.M1: { rtnOffset = 0x6E4A4; } break;
                            case XOperations.TextureID.FAMAS: { rtnOffset = 0x6E484; } break;
                            case XOperations.TextureID.MK23: { rtnOffset = 0x6E464; } break;
                            case XOperations.TextureID.CONE: { rtnOffset = 0x6E44C; } break;
                            case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT19F:
                case XOperations.Version.XOPSOLT19F2:
                    {
                        switch (id)
                        {
                            case XOperations.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case XOperations.TextureID.NONE: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CHAR_DDS: case XOperations.TextureID.CHAR_DDS2: { rtnOffset = 0x76AE8; } break;
                            case XOperations.TextureID.SCOPE_DDS: { rtnOffset = 0x76AD4; } break;
                            case XOperations.TextureID.PSG1: { rtnOffset = 0x76AB4; } break;
                            case XOperations.TextureID.SMOKE_DDS: { rtnOffset = 0x76AA0; } break;
                            case XOperations.TextureID.MFLASH_DDS: { rtnOffset = 0x76A8C; } break;
                            case XOperations.TextureID.BLOOD_DDS: { rtnOffset = 0x76A78; } break;
                            case XOperations.TextureID.YAKKYOU_DDS: { rtnOffset = 0x76A64; } break;
                            case XOperations.TextureID.MP5: { rtnOffset = 0x76A48; } break;
                            case XOperations.TextureID.GLOCK18: { rtnOffset = 0x76A28; } break;
                            case XOperations.TextureID.BULLET: { rtnOffset = 0x76A10; } break;
                            case XOperations.TextureID.M92F: { rtnOffset = 0x769F0; } break;
                            case XOperations.TextureID.TITLE_DDS: { rtnOffset = 0x769DC; } break;
                            case XOperations.TextureID.GRENADE: { rtnOffset = 0x769BC; } break;
                            case XOperations.TextureID.AK47: { rtnOffset = 0x7699C; } break;
                            case XOperations.TextureID.MP5SD: { rtnOffset = 0x7697C; } break;
                            case XOperations.TextureID.P90: { rtnOffset = 0x76960; } break;
                            case XOperations.TextureID.M249: { rtnOffset = 0x76940; } break;
                            case XOperations.TextureID.M4: { rtnOffset = 0x76924; } break;
                            case XOperations.TextureID.UMP: { rtnOffset = 0x76908; } break;
                            case XOperations.TextureID.MAC10: { rtnOffset = 0x768E8; } break;
                            case XOperations.TextureID.CAN: { rtnOffset = 0x768D0; } break;
                            case XOperations.TextureID.SKY1: { rtnOffset = -2; } break;
                            case XOperations.TextureID.CASE: { rtnOffset = 0x768B0; } break;
                            case XOperations.TextureID.M1911: { rtnOffset = 0x76894; } break;
                            case XOperations.TextureID.PC: { rtnOffset = 0x7687C; } break;
                            case XOperations.TextureID.ISU: { rtnOffset = 0x76864; } break;
                            case XOperations.TextureID.GLOCK17: { rtnOffset = 0x76844; } break;
                            case XOperations.TextureID.DAN: { rtnOffset = 0x7682C; } break;
                            case XOperations.TextureID.DE: { rtnOffset = 0x76810; } break;
                            case XOperations.TextureID.AUG: { rtnOffset = 0x767F4; } break;
                            case XOperations.TextureID.PC_SW: { rtnOffset = 0x767D8; } break;
                            case XOperations.TextureID.PC_D: { rtnOffset = 0x767C0; } break;
                            case XOperations.TextureID.M1: { rtnOffset = 0x767A4; } break;
                            case XOperations.TextureID.FAMAS: { rtnOffset = 0x76784; } break;
                            case XOperations.TextureID.MK23: { rtnOffset = 0x76764; } break;
                            case XOperations.TextureID.CONE: { rtnOffset = 0x7674C; } break;
                            case XOperations.TextureID.ADD_SMALLOBJECT: { rtnOffset = -2; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                default: { rtnOffset = -1; } break;
            } 

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 캐릭터 텍스쳐 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <param name="id">캐릭터 텍스쳐의 식별 번호</param>
        /// <returns>성공(Offset), 실패(-1), 생략(-2)</returns>
        public static long GetCharacterTextureOffset(XOperations.Version version, Character.TextureID id)
        {
            long rtnOffset = -1;

            switch(version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS096:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x661C4; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x661A4; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x66184; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x6616C; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x6614C; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x6612C; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x66114; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x66100; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x660E4; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x660CC; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x660B4; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x6609C; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x66084; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x6606C; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x66054; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x6603C; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x66024; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x66008; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x65FEC; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x65FD0; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x65FB4; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x65F98; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x65F7C; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x65F60; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x65F44; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x65F2C; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x65F10; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x65EF8; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x65EDC; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x65EC4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPS097T:
                case XOperations.Version.XOPS097FT:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x671C4; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x671A4; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x67184; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x6716C; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x6714C; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x6712C; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x67114; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x67100; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x670E4; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x670CC; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x670B4; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x6709C; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x67084; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x6706C; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x67054; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x6703C; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x67024; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x67008; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x66FEC; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x66FD0; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x66FB4; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x66F98; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x66F7C; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x66F60; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x66F44; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x66F2C; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x66F10; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x66EF8; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x66EDC; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x66EC4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPS0975T:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x79120; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x79100; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x790E0; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x790C8; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x790A8; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x79088; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x79070; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x7905C; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x79040; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x79028; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x79010; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x78FF8; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x78FE0; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x78FC8; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x78FB0; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x78F98; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x78F80; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x78F64; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x78F48; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x78F2C; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x78F10; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x78EF4; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x78ED8; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x78EBC; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x78EA0; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x78E88; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x78E6C; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x78E54; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x78E38; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x78E20; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;

                case XOperations.Version.XOPSOLT16:
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT18:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x6DF0C; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x6DFEC; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x6DECC; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x6DEB4; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x6DE94; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x6DE74; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x6DE5C; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x6DE48; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x6DE2C; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x6DE14; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x6DDFC; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x6DDE4; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x6DDCC; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x6DDB4; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x6DD9C; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x6DD84; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x6DD6C; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x6DD50; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x6DD34; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x6DD18; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x6DCFC; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x6DCE0; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x6DCC4; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x6DCA8; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x6DC8C; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x6DC74; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x6DC58; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x6DC40; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x6DC24; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x6DC0C; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT18F:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x6DF30; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x6DF10; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x6DEF0; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x6DED8; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x6DEB8; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x6DE98; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x6DE80; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x6DE6C; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x6DE50; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x6DE38; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x6DE20; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x6DE08; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x6DDF0; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x6DDD8; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x6DDC0; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x6DDA8; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x6DD90; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x6DD74; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x6DD58; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x6DD3C; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x6DD20; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x6DD04; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x6DCE8; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x6DCCC; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x6DCB0; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x6DC98; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x6DC7C; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x6DC64; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x6DC48; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x6DC30; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT18F2:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x6EF64; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x6EF44; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x6EF24; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x6EF0C; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x6EEEC; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x6EECC; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x6EEB4; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x6EEA0; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x6EE84; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x6EE6C; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x6EE54; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x6EE3C; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x6EE24; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x6EE0C; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x6EDF4; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x6EDDC; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x6EDC4; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x6EDA8; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x6ED8C; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x6ED70; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x6ED54; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x6ED38; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x6ED1C; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x6ED00; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x6ECE4; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x6ECCC; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x6ECB0; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x6EC98; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x6EC7C; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x6EC64; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT19:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x6EFB0; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x6EF90; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x6EF70; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x6EF58; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x6EF38; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x6EF18; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x6EF00; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x6EEEC; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x6EED0; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x6EEB8; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x6EEA0; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x6EE88; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x6EE70; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x6EE58; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x6EE40; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x6EE28; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x6EE10; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x6EDF4; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x6EDD8; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x6EDBC; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x6EDA0; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x6ED84; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x6ED68; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x6ED4C; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x6ED30; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x6ED18; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x6ECFC; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x6ECE4; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x6ECC8; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x6ECB0; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                case XOperations.Version.XOPSOLT19F:
                case XOperations.Version.XOPSOLT19F2:
                    {
                        switch (id)
                        {
                            case Character.TextureID.UNKNOWN: { rtnOffset = -1; } break;
                            case Character.TextureID.SOLDIER_BLACK: { rtnOffset = 0x77350; } break;
                            case Character.TextureID.SOLDIER_GREEN: { rtnOffset = 0x77330; } break;
                            case Character.TextureID.SOLDIER_WHITE: { rtnOffset = 0x77310; } break;
                            case Character.TextureID.HAGE: { rtnOffset = 0x772F8; } break;
                            case Character.TextureID.SOLDIER_VIOLET: { rtnOffset = 0x772D8; } break;
                            case Character.TextureID.SOLDIER_BLUE: { rtnOffset = 0x772B8; } break;
                            case Character.TextureID.ROBOT: { rtnOffset = 0x772A0; } break;
                            case Character.TextureID.GS: { rtnOffset = 0x7728C; } break;
                            case Character.TextureID.SOLDIER0: { rtnOffset = 0x77270; } break;
                            case Character.TextureID.POLICE: { rtnOffset = 0x77258; } break;
                            case Character.TextureID.RIIMAN: { rtnOffset = 0x77240; } break;
                            case Character.TextureID.SYATU: { rtnOffset = 0x77228; } break;
                            case Character.TextureID.ISLAM: { rtnOffset = 0x77210; } break;
                            case Character.TextureID.WOMAN: { rtnOffset = 0x771F8; } break;
                            case Character.TextureID.CIV1: { rtnOffset = 0x771E0; } break;
                            case Character.TextureID.CIV2: { rtnOffset = 0x771C8; } break;
                            case Character.TextureID.CIV3: { rtnOffset = 0x771B0; } break;
                            case Character.TextureID.SOLDIER1: { rtnOffset = 0x77194; } break;
                            case Character.TextureID.SOLDIER2: { rtnOffset = 0x77178; } break;
                            case Character.TextureID.ZOMBIE1: { rtnOffset = 0x7715C; } break;
                            case Character.TextureID.ZOMBIE2: { rtnOffset = 0x77140; } break;
                            case Character.TextureID.ZOMBIE3: { rtnOffset = 0x77124; } break;
                            case Character.TextureID.ZOMBIE4: { rtnOffset = 0x77108; } break;
                            case Character.TextureID.RIIMAN_G: { rtnOffset = 0x770EC; } break;
                            case Character.TextureID.RIIMAN_K: { rtnOffset = 0x770D0; } break;
                            case Character.TextureID.ISLAM2: { rtnOffset = 0x770B8; } break;
                            case Character.TextureID.RIIMAN_B: { rtnOffset = 0x7709C; } break;
                            case Character.TextureID.SYATU2: { rtnOffset = 0x77084; } break;
                            case Character.TextureID.SOLDIER3: { rtnOffset = 0x77068; } break;
                            case Character.TextureID.GATES: { rtnOffset = 0x77050; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    } break;
                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 시야 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <param name="type">시야 종류</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetFovOffset(XOperations.Version version, FOVType type)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;                      // Not Supported
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;                   // Not Supported
                case XOperations.Version.XOPS096:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x5D29C; } break;
                            case FOVType.AUG: { rtnOffset = 0x5D2A0; } break;
                            case FOVType.PSG1: { rtnOffset = 0x5D2A4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS097T:
                case XOperations.Version.XOPS097FT:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x5E29C; } break;
                            case FOVType.AUG: { rtnOffset = 0x5E2A0; } break;
                            case FOVType.PSG1: { rtnOffset = 0x5E2A4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS0975T:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x7AD2C; } break;
                            case FOVType.AUG: { rtnOffset = 0x7ACA0; } break;
                            case FOVType.PSG1: { rtnOffset = 0x7ACD1; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;                 // Not Supported
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;                 // Not Supported
                case XOperations.Version.XOPSOLT18:
                case XOperations.Version.XOPSOLT18F:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x6536C; } break;
                            case FOVType.AUG: { rtnOffset = 0x65370; } break;
                            case FOVType.PSG1: { rtnOffset = 0x65374; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT18F2:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x6636C; } break;
                            case FOVType.AUG: { rtnOffset = 0x66370; } break;
                            case FOVType.PSG1: { rtnOffset = 0x66374; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x66374; } break;
                            case FOVType.AUG: { rtnOffset = 0x66378; } break;
                            case FOVType.PSG1: { rtnOffset = 0x6637C; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19F:
                case XOperations.Version.XOPSOLT19F2:
                    {
                        switch (type)
                        {
                            case FOVType.NORMAL: { rtnOffset = 0x76F5C; } break;
                            case FOVType.AUG: { rtnOffset = 0x76EB0; } break;
                            case FOVType.PSG1: { rtnOffset = 0x76E3C; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 DirectX 관련 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <param name="type">DirectX 설정 종류</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetDirectXOffset(XOperations.Version version, DirectXType type)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS096:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x368D; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x3A8D; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x3A88; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS097T:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x368D; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x3A8D; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x3A88; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS097FT:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x368D; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x3A9D; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x3A98; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS0975T:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x41DA; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x7A570; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x7AD28; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT18:
                case XOperations.Version.XOPSOLT18F:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x4D4D; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x679A; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x512B; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT18F2:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x4F3D; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x698A; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x531B; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x509D; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x6AEA; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x547B; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19F:
                case XOperations.Version.XOPSOLT19F2:
                    {
                        switch (type)
                        {
                            case DirectXType.AUTODEPTHSTENCILFORMAT: { rtnOffset = 0x5929; } break;
                            case DirectXType.CLIPPINGPLANENEAR: { rtnOffset = 0x7637C; } break;
                            case DirectXType.CLIPPINGPLANEFAR: { rtnOffset = 0x76F58; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        /// <summary>
        /// 버전에 따른 게임 문자열 오프셋을 취득합니다.
        /// </summary>
        /// <param name="version">X Operations의 버전</param>
        /// <param name="type">게임 문자열 종류</param>
        /// <returns>성공(Offset), 실패(-1)</returns>
        public static long GetGameStringOffset(XOperations.Version version, GameStringType type)
        {
            long rtnOffset = -1;

            switch (version)
            {
                case XOperations.Version.None: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS093: { rtnOffset = -1; } break;
                case XOperations.Version.XOPS096:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x674E4; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x66E68; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS097T:
                case XOperations.Version.XOPS097FT:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x684E4; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x67E68; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPS0975T:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x7A474; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x79DC0; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                case XOperations.Version.XOPSOLT16: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT17: { rtnOffset = -1; } break;
                case XOperations.Version.XOPSOLT18:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x6E470; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x6E43C; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT18F:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x6E494; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x6E460; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT18F2:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x6F4D0; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x6F49C; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x6F518; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x6F4E4; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;
                case XOperations.Version.XOPSOLT19F:
                case XOperations.Version.XOPSOLT19F2:
                    {
                        switch (type)
                        {
                            case GameStringType.GAME_NAME: { rtnOffset = 0x78510; } break;
                            case GameStringType.GAME_VERSION: { rtnOffset = 0x784DC; } break;
                            default: { rtnOffset = -1; } break;
                        }
                    }
                    break;

                default: { rtnOffset = -1; } break;
            }

            return rtnOffset;
        }

        public static string GetTexturePath(string filePath, XOperations.Version version, XOperations.TextureID id)
        {
            long offset = GetTextureOffset(version, id);
            if (offset == -1) { return string.Empty; }
            if (offset == -2) { return string.Empty; }

            string rtn = string.Empty;

            // '\0'를 만날 때까지 읽는 메서드
            Func<BinaryReader, string> ReadString = (BinaryReader reader) =>
            {
                string s = string.Empty;
                char c = char.MinValue;

                while ((int)(c = reader.ReadChar()) != '\0') { s += c; }

                return s;
            };

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    br.BaseStream.Position = offset;
                    rtn = ReadString(br);
                }
            }

            return rtn;
        }

        public static string GetTexturePath(int processId, XOperations.Version version, XOperations.TextureID id)
        {
            long offset = GetTextureOffset(version, id);
            if (offset == -1) { return string.Empty; }
            if (offset == -2) { return string.Empty; }

            string rtn = string.Empty;

            WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

            pmm.ReadMemoryString((int)offset, new IntPtr(0x400000), out rtn, out int bytesRead);

            return rtn;
        }

        public static string GetCharacterTexturePath(string filePath, XOperations.Version version, Character.TextureID id)
        {
            long offset = GetCharacterTextureOffset(version, id);
            if (offset == -1) { return string.Empty; }
            if (offset == -2) { return string.Empty; }

            string rtn = string.Empty;

            // '\0'를 만날 때까지 읽는 메서드
            Func<BinaryReader, string> ReadString = (BinaryReader reader) =>
            {
                string s = string.Empty;
                char c = char.MinValue;

                while ((int)(c = reader.ReadChar()) != '\0') { s += c; }

                return s;
            };

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    br.BaseStream.Position = offset;
                    rtn = ReadString(br);
                }
            }

            return rtn;
        }

        public static string GetCharacterTexturePath(int processId, XOperations.Version version, Character.TextureID id)
        {
            long offset = GetCharacterTextureOffset(version, id);
            if (offset == -1) { return string.Empty; }
            if (offset == -2) { return string.Empty; }

            string rtn = string.Empty;

            WinAPI.ProcessMemoryManager pmm = new WinAPI.ProcessMemoryManager(processId);

            pmm.ReadMemoryString((int)offset, new IntPtr(0x400000), out rtn, out int bytesRead);

            return rtn;
        }
        #endregion
    }
}
