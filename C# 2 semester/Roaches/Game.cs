using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roaches
{
    internal class Game
    {
        private Character[] characters;
        private Random random = new Random();
        private System.Windows.Forms.Timer timer;
        private int finishX;
        private int[] positions;
        private bool gameActive = false;
        private byte place = 1;
        private byte[] result;
        public Game(int finish, System.Windows.Forms.Timer timer)
        {
            this.timer = timer;
            positions = new int[] { 56, 147, 231, 321 };
            finishX = finish;
            characters = new Character[] { new Character(Properties.Resources.furina, Properties.Resources.FurinaGif, positions[0], random), new Character(Properties.Resources.zhongli, Properties.Resources.zhongliGif, positions[1], random), new Character(Properties.Resources.raiden, Properties.Resources.RaidenShogunGif, positions[2], random), new Character(Properties.Resources.keqing, Properties.Resources.KeqingGif, positions[3], random) };
        }

        public void Start()
        {
            if (!gameActive)
            {
                result = new byte[characters.Length];
                timer.Start();
                gameActive = true;
            }
        }

        public void Stop()
        {
            if (gameActive)
            {
                timer.Stop();
                gameActive = false;
                place = 1;
            }
        }
        public void Draw(Graphics graph)
        {
            foreach (Character character in characters)
            {
                character.Draw(graph);
            }
        }

        public Bitmap GetGif(byte ind)
        {
            return characters[ind].Gif;
        }

        public void Move()
        {
            foreach (Character character in characters)
            {
                if (character.X < finishX)
                {
                    character.Move();
                }
            }
        }

        public void MoveToStart()
        {
            foreach (Character character in characters)
            {
                character.MoveToStart();
            }
        }

        public byte[] Results()
        {
            for (sbyte i = 0; i < characters.Length; i++)
            {
                if (characters[i].X >= finishX && result[i] == 0)
                {
                    result[i] = place;
                    place++;
                }
            }
            return result;
        }

        public bool CheckEnd()
        {
            byte[] results = Results();
            if (results.Max() == 4)
            {
                return true;
            }
            return false;
        }

        public bool GameActive {  get { return gameActive; } }
    }
}
