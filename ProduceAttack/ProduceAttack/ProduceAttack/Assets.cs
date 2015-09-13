using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace ProduceAttack
{
    public static class Assets
    {
        private static ContentManager UI_Content;
        public static Dictionary<UI, Texture2D> UI_Textures;
        public static Dictionary<Font, SpriteFont> UI_Fonts;

        //list of keys for textures, they match texture names
        public enum UI
        {
            Pixel,
        }

        //list of keys for fonts
        public enum Font
        {
            BuxtonSketch24,
            Tiza14,
            Tiza24,
            Tiza36,
        }

        public static void Load_UI_Assets(Game game)
        {
            if (UI_Content == null) //load only if the Content has not already been loaded
            {
                //initialize
                UI_Content = new ContentManager(game.Services, "Content");
                UI_Textures = new Dictionary<UI, Texture2D>();
                UI_Fonts = new Dictionary<Font, SpriteFont>();

                //load fonts
                SpriteFont font = null;
                font = UI_Content.Load<SpriteFont>(@"Fonts\BuxtonSketch24");
                UI_Fonts.Add(Font.BuxtonSketch24, font);
                font = UI_Content.Load<SpriteFont>(@"Fonts\Tiza14");
                UI_Fonts.Add(Font.Tiza14, font);
                font = UI_Content.Load<SpriteFont>(@"Fonts\Tiza24");
                UI_Fonts.Add(Font.Tiza24, font);
                font = UI_Content.Load<SpriteFont>(@"Fonts\Tiza36");
                UI_Fonts.Add(Font.Tiza36, font);


                //load UI textures
                Texture2D texture = null;
                texture = UI_Content.Load<Texture2D>(@"Textures\pixel");
                UI_Textures.Add(UI.Pixel, texture);
            }
            return;
        }

        private static ContentManager Audio_Music_Content;
        private static ContentManager Audio_Effect_Content;
        public static Dictionary<Music, Song> Audio_Music;
        public static Dictionary<Sound, SoundEffect> Audio_Effect;

        public enum Music //keys for soundtracks
        {
            Credits,
            Desert1,
            Desert2,
            Factory1,
            Factory2,
            FinalBoss1,
            Forest1,
            Forest2,
            Grass1,
            Grass2,
            Snow1,
            Snow2,
            Title,
            Training
        }

        public enum Sound //keys for audio effects
        {

        }

        public static void Load_Audio_Assets(Game game)
        {
            if (Audio_Effect_Content == null)
            {
                //initialize
                Audio_Effect_Content = new ContentManager(game.Services, "Content");
                Audio_Effect = new Dictionary<Sound, SoundEffect>();

                //load sound effects
                //none yet
            }

            if (Audio_Music_Content == null)
            {
                //intialize
                Audio_Music_Content = new ContentManager(game.Services, "Content");
                Audio_Music = new Dictionary<Music, Song>();

                //load starting tracks
                Song song = Audio_Music_Content.Load<Song>(@"Music\Title");
                Audio_Music.Add(Music.Title, song);
            }
            return;
        }

        public static void Play_Music_Track(Music track)
        {
            Song play_this = null;

            //try to get the song, if it was not loaded, then load it, and get it 
            Audio_Music.TryGetValue(track, out play_this);
            if (play_this == null)
            {
                Load_Music_Track(track);
                Audio_Music.TryGetValue(track, out play_this);
            }

            //play it
            MediaPlayer.Play(play_this);
            return;
        }

        public static void Load_Music_Track(Music song)
        {
            Song track = null;
            //load track
            switch (song)
            {
                case Music.Credits:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Credits");
                        Audio_Music.Add(Music.Credits, track);
                        break;
                    }
                case Music.Desert1:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Desert1");
                        Audio_Music.Add(Music.Desert1, track);
                        break;
                    }
                case Music.Desert2:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Desert2");
                        Audio_Music.Add(Music.Desert2, track);
                        break;
                    }
                case Music.Factory1:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Factory1");
                        Audio_Music.Add(Music.Factory1, track);
                        break;
                    }
                case Music.Factory2:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Factory2");
                        Audio_Music.Add(Music.Factory2, track);
                        break;
                    }
                case Music.FinalBoss1:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\FinalBoss1");
                        Audio_Music.Add(Music.FinalBoss1, track);
                        break;
                    }
                case Music.Forest1:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Forest1");
                        Audio_Music.Add(Music.Forest1, track);
                        break;
                    }
                case Music.Forest2:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Forset2");
                        Audio_Music.Add(Music.Forest2, track);
                        break;
                    }
                case Music.Grass1:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Grass1");
                        Audio_Music.Add(Music.Grass1, track);
                        break;
                    }
                case Music.Grass2:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Grass2");
                        Audio_Music.Add(Music.Grass2, track);
                        break;
                    }
                case Music.Snow1:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Snow1");
                        Audio_Music.Add(Music.Snow1, track);
                        break;
                    }
                case Music.Snow2:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Snow2");
                        Audio_Music.Add(Music.Snow2, track);
                        break;
                    }
                case Music.Title:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Title");
                        Audio_Music.Add(Music.Title, track);
                        break;
                    }
                case Music.Training:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Training");
                        Audio_Music.Add(Music.Training, track);
                        break;
                    }
                default:
                    {
                        track = Audio_Music_Content.Load<Song>(@"Music\Credits");
                        Audio_Music.Add(Music.Credits,track);
                        break;
                    }
            }
            return;
        }

    }
}
