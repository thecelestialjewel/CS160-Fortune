using System;
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
    public partial class Fortune : Form
    {
        private static Random random = new Random(DateTime.Now.Millisecond); //this class helps generate random numbers-cmj
        public int selectedNum { get; private set; }

        //string fortuneMessage;

        public Fortune()
        {
            InitializeComponent();
        }

        private void numSelector_ValueChanged(object sender, EventArgs e)//handling with this method
        {
            try
            {
                NumericUpDown selector = (NumericUpDown)sender;//send this information to the event handler
                selectedNum = (int)selector.Value;

                if (selectedNum > 21 || selectedNum < 0)
                {
                    throw new Exception("Oh snap! You need to pick a number between 0-21, you selected " + selectedNum + "!");
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
            //https://www.biddytarot.com/tarot-card-meanings/major-arcana/
            fortuneMessage[0] = card + "Fool card:\n\n Have an open curious mind and sense of excitement. You don’t need to wait for someone to give you the green light or hold off until you have all the skills, tools and resources you think you might need. You are ready!Live life as though you were a child once again. Laugh more, dance, and let your heart go free. You never know what the future holds, but like the Fool, you must step into the unknown, trusting that the Universe will catch you and escort you along the way. Take a chance and see what happens.";
            fortuneMessage[1] = card + "Magician card:\n\n Everything you need right now is at your fingertips. You are ready to turn your ideas into reality. Establish a clear vision of what will create before you act. Have clear goals that talk to your soul. Be methodical in your planning to make sure that you stay on track and carry out your tasks.";
            fortuneMessage[2] = card + "High Priestess card:\n\n Connect with your intuition through meditation, visualization, journeying, and being part of a spiritual community. Look for areas in your life that may be out of balance and trust your intuition to correct them. Regardless of your gender, it is vital for you to balance and integrate your masculine and feminine energies, and the presence of the High Priestess signals that your sacred feminine needs your attention right now. Feel, rather than think. Collaborate, rather than compete. Create, rather than destroy. Trust your Divine Feminine energy, even if the masculine energy around you may appear to be stronger.";
            fortuneMessage[3] = card + "Empress card:\n\n Connect with your senses to experience a deep fulfillment. Discover different approaches to express yourself creatively through painting, music, drama, or other fine arts. You are in a period of growth, in which all you have dreamed of is now coming true. You see it as a gift and an honour to tend to others, and in doing so you, too, receive benefit. In a more literal sense, you may step into the role of ‘mother’, perhaps as the mother of a newborn, caretaker of other people’s children, or spending more quality time with your kids.";
            fortuneMessage[4] = card + "The Emperor:\n\n You are comfortable in a leadership role where you can direct others. Listen to the advice of others, but you need to have the final say. Create calm out of chaos by breaking down  problems and using a systematic approach to solve them. Through the course of your life, you have gained valuable wisdom and life experience, and now you enjoy offering guidance, advice, and direction to someone who might benefit from it.";
            fortuneMessage[5] = card + "The Hierophant:\n\n You will undertake a period of formal study as you delve into a subject that has been widely documented. You adhere to key principles and rules that you know will lead to a successful result. You enjoy a deep sense of comfort being surrounded by people with well established belief systems. This card is about identifying with others and a way of thinking that will prompt further learning.";
            fortuneMessage[6] = card + "The Lovers:\n\n Be vulnerable, open your heart, and share your truest feelings. You will create a harmonious and fulfilling relationship built on trust and respect. It is time to go into the world and make choices for yourself, staying true to who you are and being authentic in your endeavors. The Lovers card is often a sign that you are facing a moral dilemma and must consider all consequences before acting. ";
            fortuneMessage[7] = card + "The Chariot:\n\n Don’t be passive and just hope things will work in your favor. Take action and stay on course regardless of what challenges you will face. When others will try to distract you from your goal, draw upon your willpower. You will be successful as long as your remain confident in your abilities. Be bold in expressing your desires and laying down your boundaries; otherwise, you will not get your way. You need to have faith in yourself and know fundamentally who you are and what you stand for (thus building off the personal belief systems and values established through the Lovers card).";
            fortuneMessage[8] = card + "Strength:\n\n You are fueled by your strong will and determination. Your strength gives you the confidence to overcome challenges and fears. Tame your animal instincts and channel these responses constructively. Its what you do with emotions that makes a difference. This is no time to act out in rage or hatred. Approach your situation from a place of forgiveness, love and compassion.";
            fortuneMessage[9] = card + "The Hermit:\n\n Your most profound sense of truth is within you and not in the distractions of the outside world. When you allow yourself to tune into your inner guiding light you will hear the answers you need to grow wise beyond your years. Finally, the Hermit may appear in your life as a spiritual mentor here to raise your vibration and enhance your consciousness. The beauty of this mentor is that, while he may be an expert in his own right, he will teach you how to find your answers within you.";
            fortuneMessage[10] = card + "Wheel of Fortune:\n\n Be kind and loving to others and they will be kind and loving to you. If you want happiness and abundance make sure you are sending out positive juju. What you send out in the universe will come back your way. You need to accept what is happening and adapt. Go with the flow! Opportunities you could never imagine are suddenly available to you, and you have the chance to make a significant change in your life. While it may be unexpected and unfamiliar, see this as an invitation to turn things around and take an entirely new direction in your life.";
            fortuneMessage[11] = card + "Justice:\n\n Once the decision is made, you must accept it and move on; there are no retrials or second chances with the upright Justice card. Be aware of the impact your decisions will have on your well-being and the well-being of others. Choose consciously by connecting with your inner guidance system (your intuition) and asking for the answer that is most in alignment with the highest good of all.";
            fortuneMessage[12] = card + "The Hanged Man:\n\n If you’re in tune with your intuition, you’ll start to have a sense for when it’s time to hit the brakes and put things on hold – before things get out of hand. But if you’re out of alignment and oblivious to those intuitive signs, the Universe will probably put things on hold for you, in the form of continued obstacles, ill-health, and breakdowns. Take time away from your routine to connect with a new way of thinking and seeing.If you push or resist, you will meet more obstacles along the way; instead, ‘allow’ the opportunities to flow smoothly and effortlessly to you. ";
            fortuneMessage[13] = card + "Death:\n\n The Death card symbolises the end of a major phase or aspect of your life that you realise is no longer serving you, opening up the possibility of something far more valuable and essential.You need to transform yourself and clear away the old to bring in the new. Any change should be welcomed as a positive, cleansing, transformational force in your life. ";
            fortuneMessage[14] = card + "Temperance:\n\n Maintain an even temperament and manage your emotions. You have learned to keep composed in stressful situations. Now is not the time to be highly opinionated or controversial. Be the peacekeeper and take a balanced and moderate approach, avoiding any extremes. Your inner voice is guiding you to the right outcome, and you are patiently listening and following.";
            fortuneMessage[15] = card + "Devil:\n\n The Devil card often appears when you have been tricked into thinking you have no control over your shadow self or these negative forces, and that you can never break free from their hold. To break free of these negative patterns, you need to acknowledge the hold they have over you and the impact they are having on your life. Given that the Devil is a Major Arcana card, it is unlikely that you will be free from your addictions and dependencies overnight. It may be a recurring pattern for you, and it will take a tremendous amount of willpower and strength to free yourself from their influence. But know this: it IS possible, and it is up to you to make it happen. ";
            fortuneMessage[16] = card + "Tower:\n\n A lightning bolt of clarity and insight cuts through the lies and illusions you have been telling yourself, and now the truth comes to light. The best way forward is to let this structure self-destruct so you can re-build and re-focus. Change on this deep level is hard, but you need to trust that life is happening FOR you, not TO you and this is all for a reason. This destruction will allow new growth to emerge and your soul can evolve.";
            fortuneMessage[17] = card + "Star:\n\n You are entering a peaceful, loving phase in your life, filled with calm energy, mental stability and more in-depth understanding of both yourself and others around you. Allow yourself to dream, to aspire, to elevate in any way possible so you can reach the stars. Strip back any limiting beliefs, facades, or deceptions, and live in your authentic nature. Be open to new ideas and growth, and listen to the still voice within.";
            fortuneMessage[18] = card + "Moon:\n\n Be careful of making fast decisions when the Moon appears because you may later realise you only had half the information you needed. You need to listen to and trust your intuition so you can see beyond what is in front of you. Let go of your conscious mental blocks or negative self-talk and allow your intuition to guide you. Your dreams, intuitions and inner guidance lead you forward toward higher levels of understanding if you listen and use your judgement to help interpret the messages of the subconscious.";
            fortuneMessage[19] = card + "Sun:\n\n The Sun brings you the message you have been waiting for: that things will get better, a lot better! Through the challenges along your path, you discovered who you are and why you’re here. You have what others want and are being asked to radiate your energy and your gifts out into the world in a big way. Tap into your power and use your Divine will to express that power in positive ways.";
            fortuneMessage[20] = card + "Judgement:\n\n You may be at a crossroads, aware that any choice you make will bring a significant change with long-lasting effects. Tune in to your Higher Self, trust your judgement and know you are on the right path. If you still need clarity on the situation, look to your past and life lessons to guide you. All the pieces of the puzzle of your life are finally coming together to form one, unified picture of your life story. you may find comfort in sharing your struggles with others within a group environment.";
            fortuneMessage[21] = card + "The world:\n\n Celebrate your successes and bask in the joy of having brought your goals to fruition. Express gratitude for what you have created and harvested. Finally, make sure you don’t rush into the next big project; celebrating your journey will set you up for success when you are ready for your next challenge. Look back at your past experiences and acknowledge how far you have come and what you learned along the way. It may surprise you to look back at your progress and see how much you achieved.";


            {
                MessageBox.Show(fortuneMessage[random.Next(0, 21)], "Your fortune card:");

            }
        }

        private void btnLuckyNumbers_Click(object sender, EventArgs e)
        {
            int[] luckynumbers = GenerateLuckyNumbers();


            string commaseperatorluckynumber = string.Join(", ", luckynumbers);
            MessageBox.Show("Your lucky numbers: " + commaseperatorluckynumber, "Lucky Numbers");


        }
        public static int[] GenerateLuckyNumbers()
        {
            int[] luckyNumbers = new int[6]; //int array for lucky numbers
            for (int i = 0; i < 6; i++) //this is the loop -cmj
            {
                luckyNumbers[i] = random.Next(1, 49);//random numbers 1 through 49
            }
            return luckyNumbers;

        }

        private void DisclaimerBtn_Click(object sender, EventArgs e)
        {
            //NOTE: Reference URL https://teachmetarot.com/about-course/terms-and-conditions/legal-disclaimer/
            string disclaimer = @"Although Tarot Reading is used as a self-counselling tool for spiritual growth and personal development, it is ultimately viewed as a form of Entertainment.

Tarot Reading is subject to interpretation and should not be taken as Absolute.A Tarot Reading is never 100 % accurate, therefore it should never be fully trusted.A Tarot Reading does not replace Professional Medical/ Legal / Business Opinion and Advice on any occasion, regardless of how convinced you are that your Reading is accurate and the Reader to be trusted.If you are suffering severe difficulties in any of the above areas of; health, mental health, legalities and business concerns, you must consult with those Professionally Qualified to give suitable treatment or advice.A tarot reading, whether holistic or psychic, may not be suffice under the circumstances.

Tarot Reading or Teaching will not Force you to follow a particular course of action, or attempt to exert any form of control over your free - will and common sense.Any decisions made, or actions taken by you as a result of your Tarot Reading or embarking upon The Truly Teach Me Tarot Course is your sole responsibility and has not been forced upon you, by me, your Tarot Reader or Teacher.I will not be held legally responsible for same.It is only with the complete understanding and acceptance of the above that a tarot reading or the use of content available through this course can be permitted.Neither can I assume any legal liability for any damages or alleged damages, losses, or other direct or indirect consequences of any client decisions / actions, subsequent to, or based on my Tarot Readings or Teachings.Your participation in this site is subject to the above terms and understanding, and is solely at your own risk.";
            MessageBox.Show(disclaimer, "Fortune Disclaimer!");
        }

        private void Fortune_Load(object sender, EventArgs e)
        {

        }
    }
}