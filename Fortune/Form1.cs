﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int selectedNum { get; private set; }

        //string fortuneMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void numSelector_ValueChanged(object sender, EventArgs e)//handling with this method
        {
            try
            {
                NumericUpDown selector = (NumericUpDown)sender;//send this information to the event handler
                selectedNum = (int)selector.Value;

                if (selectedNum > 22 || selectedNum < 0)
                {
                    throw new Exception("Oh snap! You need to be a number between 0-21, you selected " + selectedNum + "!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "You screwed up!");
                
            }
        }
        private void btnClickForFortune_Click(object sender, EventArgs e)
        {
 
            string[] fortuneMessage = new string[22];// string array for fortune message

            string card = "You've got the ";
            //https://www.tarot.com/tarot/cards/major-arcana
            fortuneMessage[0] = card + "Fool card:\n\n Beginnings, innocence, spontaneity, a free spirit";
            fortuneMessage[1] = card + "Magician card: Everything you need right now is at your fingertips. You are ready to turn your ideas into reality. Establish a clear vision of what will create before you act. Have clear goals that talk to your soul";
            fortuneMessage[2] = card + "High Priestess card: Connect with your intuition through meditation, visualization, journeying, and being part of a spiritual community. Look for areas in your life that may be out of balance and trust your intuition to correct them";
            fortuneMessage[3] = card + "Empress card: Connect with your senses to experience a deep fulfillment. Discover different approaches to express yourself creatively through painting, music, drama, or other fine arts. You are in a period of growth, in which all you have dreamed of is now coming true";
            fortuneMessage[4] = card + "The Emperor: You are comfortable in a leadership role where you can direct others. Listen to the advice of others, but you need to have the final say. Create calm out of chaos by breaking down  problems and using a systematic approach to solve them";
            fortuneMessage[5] = card + "The Hierophant: You will undertake a period of formal study as you delve into a subject that has been widely documented. You adhere to key principles and rules that you know will lead to a successful result. You enjoy a deep sense of comfort being surrounded by people with well established belief systems";
            fortuneMessage[6] = card + "The Lovers: Be vulnerable, open your heart, and share your truest feelings. You will create a harmonious and fulfilling relationship built on trust and respect. It is time to go into the world and make choices for yourself, staying true to who you are and being authentic in your endeavors";
            fortuneMessage[7] = card + "The Chariot: Don’t be passive and just hope things will work in your favor. Take action and stay on course regardless of what challenges you will face. When others will try to distract you from your goal, draw upon your willpower. You will be successful as long as your remain confident in your abilities";
            fortuneMessage[8] = card + "Strength: You are fueled by your strong will and determination. Your strength gives you the confidence to overcome challenges and fears. Tame your animal instincts and channel these responses constructively. Its what you do with emotions that makes a difference";
            fortuneMessage[9] = card + "The Hermit: Your most profound sense of truth is within you and not in the distractions of the outside world. When you allow yourself to tune into your inner guiding light you will hear the answers you need to grow wise beyond your years";
            fortuneMessage[10] = card + "Wheel of Fortune: Be kind and loving to others and they will be kind and loving to you. If you want happiness and abundance make sure you are sending out positive juju. What you send out in the universe will come back your way. You need to accept what is happening and adapt. Go with the flow";
            fortuneMessage[11] = card + "Justice: ";
            fortuneMessage[12] = card + "The Hanged Man: ";
            fortuneMessage[13] = card + "Death: ";
            fortuneMessage[14] = card + "Temperance ";
            fortuneMessage[15] = card + ": ";
            fortuneMessage[16] = card + ": ";
            fortuneMessage[17] = card + ": ";
            fortuneMessage[18] = card + ": ";
            fortuneMessage[19] = card + ": ";
            fortuneMessage[20] = card + ": ";
            fortuneMessage[21] = card + ": ";
            
           

            {
                MessageBox.Show("Your fortune: \n\n"
                                    + fortuneMessage[selectedNum]);
                
            }
        }

        private void btnLuckyNumbers_Click(object sender, EventArgs e)
        {
            int[] luckynumbers = GenerateLuckyNumbers();

            
            string commaseperatorluckynumber = string.Join(", ", luckynumbers);
            MessageBox.Show("Your lucky numbers: " + commaseperatorluckynumber);


            }
        public static int [] GenerateLuckyNumbers()
        {
            int[] luckyNumbers = new int[6]; //int array for lucky numbers
            for (int i = 0; i < 6; i++)
            {
                Random rnd = new Random();
                luckyNumbers[i] = rnd.Next(1, 49);//random numbers 1 through 49
            }
            return luckyNumbers;

        }
    }
}