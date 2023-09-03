using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;
using HarmonyLib;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.EnemyUnits.Normal;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using static _8BitMusicMod.BepinexPlugin;

namespace _8BitMusicMod
{
    public class BgmDefinitions
    {
        /*[OverwriteVanilla]
        public sealed class MainmenuBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "MainMenu";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("badApple.ogg", AudioType.OGGVORBIS, directorySource);
            }
            [DontOverwrite]
            public override BgmConfig MakeConfig()
            {
                throw new NotImplementedException();
            }
        }*/
        [OverwriteVanilla]
        public sealed class Stage3Bgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Stage3";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {

                // ResourceLoader.LoadAudioClip can fetch a clip from web as it uses UnityWebRequestMultimedia.GetAudioClip
                return ResourceLoader.LoadAudioClip("_8BitMusicMod" + "\\" + "Diao Ye Zong The Fantastic Tales from Tōno (Touhou PCB) 8bit LSDj Remix.ogg", AudioType.OGGVORBIS, directorySource);

            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "Diao Ye Zong The Fantastic Tales from Tōno (Touhou PCB) 8bit LSDj Remix";
                config.Artist = "ZahranW";
                config.Original = "ティアオイエツォン(withered leaf), 遠野幻想物語";
                config.LoopStart = (float?)0.17;
                config.LoopEnd = (float?)326.77;
                return config;
            }
        }
        [OverwriteVanilla]
        public sealed class ReimuBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Reimu";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {

                // ResourceLoader.LoadAudioClip can fetch a clip from web as it uses UnityWebRequestMultimedia.GetAudioClip
                return ResourceLoader.LoadAudioClip("_8BitMusicMod" + "\\" + "The World Is Made In An Adorable Way (Touhou UDoALG) 8bit LSDj Remix.ogg", AudioType.OGGVORBIS, directorySource);

            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "The World Is Made In An Adorable Way (Touhou UDoALG) 8bit LSDj Remix";
                config.Artist = "ZahranW";
                config.Original = "世界は可愛く出来ている";
                config.LoopStart = (float?)46.125;
                config.LoopEnd = (float?)217.575;
                return config;
            }
        }
        [OverwriteVanilla]
        public sealed class JunkoBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return "Junko";
            }
            public override UniTask<AudioClip> LoadAudioClipAsync()
            {

                // ResourceLoader.LoadAudioClip can fetch a clip from web as it uses UnityWebRequestMultimedia.GetAudioClip
                return ResourceLoader.LoadAudioClip("_8BitMusicMod" + "\\" + "Pure Furies ~ Whereabouts of the Heart (Touhou LoLK) 8bit LSDj Remix.ogg", AudioType.OGGVORBIS, directorySource);

            }
            public override BgmConfig MakeConfig()
            {
                var config = BgmConfig.FromID(GetId());
                config.TrackName = "Pure Furies ~ Whereabouts of the Heart (Touhou LoLK) 8bit LSDj Remix";
                config.Artist = "ZahranW";
                config.LoopStart = (float?)39.12;
                config.LoopEnd = (float?)284.72;
                return config;
            }
        }
        public sealed class DoremyBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return nameof(Doremy);
            }

            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("_8BitMusicMod" + "\\" + "[8bit LSDj] Eternal Spring Dream (Touhou LoLK) Chiptune Remix.ogg", AudioType.OGGVORBIS, directorySource);

            }

            public override BgmConfig MakeConfig()
            {
                var config = new BgmConfig(
                        ID: "",
                        No: 0,
                        Show: true,
                        Name: "",
                        Folder: "",
                        Path: "",
                        LoopStart: (float?)74.8,
                        LoopEnd: (float?)295.25,
                        TrackName: "[8bit LSDj] Eternal Spring Dream (Touhou LoLK) Chiptune Remix",
                        Artist: "ZahranW",
                        Original: "Eternal Spring Dream",
                        Comment: ""
                );

                return config;
            }
        }
        public sealed class HardworkRabbitBgm : BgmTemplate
        {
            public override IdContainer GetId()
            {
                return nameof(HardworkRabbit);
            }

            public override UniTask<AudioClip> LoadAudioClipAsync()
            {
                return ResourceLoader.LoadAudioClip("_8BitMusicMod" + "\\" + "[8bit LSDj] The Rabbit Has Landed (Touhou LoLK) Remix.ogg", AudioType.OGGVORBIS, directorySource);

            }

            public override BgmConfig MakeConfig()
            {
                var config = new BgmConfig(
                        ID: "",
                        No: 0,
                        Show: true,
                        Name: "",
                        Folder: "",
                        Path: "",
                        LoopStart: (float?)92.85,
                        LoopEnd: (float?)197.35,
                        TrackName: "[8bit LSDj] The Rabbit Has Landed (Touhou LoLK) Remix",
                        Artist: "ZahranW",
                        Original: "兎は舞い降りた",
                        Comment: ""
                );

                return config;
            }
        }
        [HarmonyPatch(typeof(AudioManager), nameof(AudioManager.PlayEliteBgm))]
        class AudioManager_PlayEliteBgm_Patch
        {

            static bool Prefix()
            {

                if (GameMaster.Instance?.CurrentGameRun?.CurrentStation is BattleStation bs)
                {
                    if (bs.EnemyGroup.Alives.Any(e => e.Id == nameof(Doremy)))
                    {
                        AudioManager.PlayInLayer1((new DoremyBgm()).UniqueId);
                        return false;

                    }
                }
                return true;

            }
        }
        [HarmonyPatch(typeof(AudioManager), nameof(AudioManager.EnterStage))]
        class AudioManager_EnterStage_Patch
        {

            static bool Prefix()
            {

                if (GameMaster.Instance?.CurrentGameRun?.CurrentStation is BattleStation bs)
                {
                    if (bs.EnemyGroup.Alives.Any(e => e.Id == nameof(HardworkRabbit)))
                    {
                        AudioManager.PlayInLayer1((new HardworkRabbitBgm()).UniqueId);
                        return false;

                    }
                }
                return true;

            }
        }
    }
}
