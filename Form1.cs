using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stani_Bogat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int level = 0;
        int otkaz = 0;
        int fiftyfiftyindicator = 0;
        string finalanswer = "";
        int safetynet = 5;
        string[] levels = { "15•", "14", "13", "12", "11", "10", "9", "8", "7", "6", "5•", "4", "3", "2", "1" };
        string[] amounts = { "100 000", "50 000", "30 000", "20 000", "10 000", "5 000", "3 000", "2 000", "1 500", "1 000", "500", "400", "300", "200", "100" };
        string[] questions = {
            "Кой химичен елемент е под атомен номер 1 в Периодичната таблица?",
            "Кой от следните езици не използва кирилицата като основна азбука?",
            "Кои два месеца са кръстени на хора?",
            "Къде се съдържа близо 3/4 от прясната вода на Земята?",
            "Кое число събрано със себе си, умножено по себе си, и повдигнато на степен себе си би дало един и същи резултат?",
            "Кое вещество е още известно като блатен газ?",
            "Какво държат лъвовете, изобразени на герба на Варна?",
            "Президент на коя южноамериканска страна в периода от 2010 до 2016 г. е била потомка на български емигрант?",
            "С каква информация относно произволен гражданин не можем да се сдобием, ако имаме неговото ЕГН?",
            "При колко градуса температурните скали на Целзий и Фаренхайт се изравняват?",
            "Какъв е номиналът на първата българска банкнота, отпечатана през август 1885 г.?",
            "Какво означава в буквален превод титлата фараон?",
            "Първата ТВ реклама е 10-секунден клип, излъчен преди бейзболен мач през 1941 г. Какво рекламира тя?",
            "Кой писател е бил отвлечен от алжирски пирати и прекарва пет години от живота си като пленник в Африка?",
            "Коя държава от 1919 г. до днес променя флага си над 20 пъти, повече от всяка друга страна за този период?" };

        List<string[]> answers = new List<string[]> {
            new string[] { "Водород", "Хелий", "Йод", "Кислород", "A", "C" },
            new string[] { "Български език", "Гръцки език", "Руски език", "Украински език", "B", "D" },
            new string[] { "Февруари и март", "Май и юни", "Юли и август", "Ноември и декември", "C", "A" },
            new string[] { "В язовирите", "В ледниците", "В облаците", "В реките", "B", "D" },
            new string[] { "-1", "0", "1", "2", "D", "B" },
            new string[] { "Метан", "Азот", "Хелий", "Хлор", "A", "C" },
            new string[] { "Меч", "Кръст", "Котва", "Харпун", "C", "D" },
            new string[] { "Аржентина", "Боливия", "Венецуела", "Бразилия", "D", "C" },
            new string[] { "Векът, в който е роден", "Полът му", "Областта, в която е роден", "Часът, в който е роден", "D", "C" },
            new string[] { "20", "0", "-20", "-40", "D", "A" },
            new string[] { "5 лева", "10 лева", "20 лева", "50 лева", "C", "A" },
            new string[] { "Голям дом", "Баща на народите", "Цар на царете", "Живо божество", "A", "D" },
            new string[] { "Лекарство", "Часовници", "Кандидат-президент", "Екскурзия", "B", "A" },
            new string[] { "Даниел Дефо", "Гюстав Флобер", "Мигел де Сервантес", "Чарлз Дикенс", "C", "D" } ,
            new string[] { "Афганистан", "Ирак", "Сомалия", "Сирия", "A", "D" } };
        int[] audiencepercents = { 0, 0, 0, 0 };
        Random rand = new Random();
        private void AnswerA(object sender, EventArgs e)
        {
            if (answerA.Text == "Да")
            {
                safetynet = level;
                levels[15 - safetynet] = levels[15 - safetynet] + "•";
                leveltree.Text = String.Join("\n", levels);
                moneytree.Text = String.Join("\n", amounts);
                answerAbox.Image = Properties.Resources.left_final;
                answerA.BackColor = Color.FromArgb(202, 112, 53);
                announceA.BackColor = Color.FromArgb(202, 112, 53);
                answerA.ForeColor = Color.FromArgb(0, 0, 0);
                announceA.ForeColor = Color.FromArgb(0, 0, 0);
                tothequestion.Visible = true;
                tothequestion.Enabled = true;
                answerAbox.Enabled = false;
                answerBbox.Enabled = false;
            }
            else
            {
                finalanswer = "A";
                answerAbox.Image = Properties.Resources.left_final;
                answerA.BackColor = Color.FromArgb(202, 112, 53);
                announceA.BackColor = Color.FromArgb(202, 112, 53);
                answerA.ForeColor = Color.FromArgb(0, 0, 0);
                announceA.ForeColor = Color.FromArgb(0, 0, 0);
                lifeline.BackgroundImage = null;
                lifelinetext.Text = "";
                lifelinetext.BackColor = Color.Transparent;
                answerreveal.Visible = true;
                answerreveal.Enabled = true;
                answerAbox.Enabled = false;
                answerBbox.Enabled = false;
                answerCbox.Enabled = false;
                answerDbox.Enabled = false;
                fiftyfifty.Enabled = false;
                askthaudience.Enabled = false;
                phoneafriend.Enabled = false;
                walkingaway.Enabled = false;
            }
        }

        private void AnswerB(object sender, EventArgs e)
        {
            if (answerB.Text == "Не")
            {
                answerBbox.Image = Properties.Resources.right_final;
                announceB.BackColor = Color.FromArgb(202, 112, 53);
                answerB.BackColor = Color.FromArgb(202, 112, 53);
                announceB.ForeColor = Color.FromArgb(0, 0, 0);
                answerB.ForeColor = Color.FromArgb(0, 0, 0);
                tothequestion.Visible = true;
                tothequestion.Enabled = true;
                answerAbox.Enabled = false;
                answerBbox.Enabled = false;
                if (level == 13)
                {
                    safetynet = 14;
                    levels[15 - safetynet] = levels[15 - safetynet] + "•";
                    leveltree.Text = String.Join("\n", levels);
                    moneytree.Text = String.Join("\n", amounts);
                }
            }
            else
            {
                finalanswer = "B";
                answerBbox.Image = Properties.Resources.right_final;
                answerB.BackColor = Color.FromArgb(202, 112, 53);
                announceB.BackColor = Color.FromArgb(202, 112, 53);
                answerB.ForeColor = Color.FromArgb(0, 0, 0);
                announceB.ForeColor = Color.FromArgb(0, 0, 0);
                lifeline.BackgroundImage = null;
                lifelinetext.Text = "";
                lifelinetext.BackColor = Color.Transparent;
                answerreveal.Visible = true;
                answerreveal.Enabled = true;
                answerAbox.Enabled = false;
                answerBbox.Enabled = false;
                answerCbox.Enabled = false;
                answerDbox.Enabled = false;
                fiftyfifty.Enabled = false;
                askthaudience.Enabled = false;
                phoneafriend.Enabled = false;
                walkingaway.Enabled = false;
            }
        }

        private void AnswerC(object sender, EventArgs e)
        {
            finalanswer = "C";
            answerCbox.Image = Properties.Resources.left_final;
            announceC.BackColor = Color.FromArgb(202, 112, 53);
            answerC.BackColor = Color.FromArgb(202, 112, 53);
            announceC.ForeColor = Color.FromArgb(0, 0, 0);
            answerC.ForeColor = Color.FromArgb(0, 0, 0);
            lifeline.BackgroundImage = null;
            lifelinetext.Text = "";
            lifelinetext.BackColor = Color.Transparent;
            answerreveal.Visible = true;
            answerreveal.Enabled = true;
            answerAbox.Enabled = false;
            answerBbox.Enabled = false;
            answerCbox.Enabled = false;
            answerDbox.Enabled = false;
            fiftyfifty.Enabled = false;
            askthaudience.Enabled = false;
            phoneafriend.Enabled = false;
            walkingaway.Enabled = false;
        }

        private void AnswerD(object sender, EventArgs e)
        {
            finalanswer = "D";
            answerDbox.Image = Properties.Resources.right_final;
            answerD.BackColor = Color.FromArgb(202, 112, 53);
            announceD.BackColor = Color.FromArgb(202, 112, 53);
            answerD.ForeColor = Color.FromArgb(0, 0, 0);
            announceD.ForeColor = Color.FromArgb(0, 0, 0);
            lifeline.BackgroundImage = null;
            lifelinetext.Text = "";
            lifelinetext.BackColor = Color.Transparent;
            answerreveal.Visible = true;
            answerreveal.Enabled = true;
            answerAbox.Enabled = false;
            answerBbox.Enabled = false;
            answerCbox.Enabled = false;
            answerDbox.Enabled = false;
            fiftyfifty.Enabled = false;
            askthaudience.Enabled = false;
            phoneafriend.Enabled = false;
            walkingaway.Enabled = false;
        }

        private void StartTheGame(object sender, EventArgs e)
        {
            level++;
            question.Text = questions[level - 1];
            announce.Text = "Въпрос #" + level + " за " + amounts[15 - level] + " лева:";
            answerA.Text = answers[level - 1][0];
            answerB.Text = answers[level - 1][1];
            answerC.Text = answers[level - 1][2];
            answerD.Text = answers[level - 1][3];
            answerAbox.Enabled = true;
            answerBbox.Enabled = true;
            answerCbox.Enabled = true;
            answerDbox.Enabled = true;
            fiftyfifty.Enabled = true;
            askthaudience.Enabled = true;
            phoneafriend.Enabled = true;
            leveltree.Text = String.Join("\n", levels);
            moneytree.Text = String.Join("\n", amounts);
            startgame.Enabled = false;
            startgame.Visible = false;
        }

        private void FiftyFifty(object sender, EventArgs e)
        {
            if (answers[level - 1].Contains("A") == false)
            {
                answerA.Text = "";
                answerAbox.Enabled = false;
            }
            if (answers[level - 1].Contains("B") == false)
            {
                answerB.Text = "";
                answerBbox.Enabled = false;
            }
            if (answers[level - 1].Contains("C") == false)
            {
                answerC.Text = "";
                answerCbox.Enabled = false;
            }
            if (answers[level - 1].Contains("D") == false)
            {
                answerD.Text = "";
                answerDbox.Enabled = false;
            }
            fiftyfiftyindicator = level;
            fiftyfifty.Enabled = false;
            fiftyfifty.BackgroundImage = Properties.Resources._5050x;
        }

        private void PhoneAFriend(object sender, EventArgs e)
        {
            lifeline.BackgroundImage = Properties.Resources.friendlifeline;
            lifelinetext.Text = "- Мисля, че е отговор " + answers[level - 1][4] + "!";
            lifelinetext.Size = new Size(115, 41);
            lifelinetext.Location = new Point(87, 147);
            lifelinetext.BackColor = Color.FromArgb(8, 75, 184);
            askthaudience.Enabled = false;
            askthaudience.BackgroundImage = Properties.Resources.friendx;
        }

        private void AskTheAudience(object sender, EventArgs e)
        {
            if (fiftyfiftyindicator != level)
            {
                int percent1 = rand.Next(50, 100);
                audiencepercents[(int)char.Parse(answers[level - 1][4]) - 65] = percent1;
                int percent2 = rand.Next(1, 100 - percent1);
                audiencepercents[(int)char.Parse(answers[level - 1][5]) - 65] = percent2;
                int percent3 = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (audiencepercents[i] == 0)
                    {
                        audiencepercents[i] = rand.Next(0, (100 - (percent1 + percent2)));
                        percent3 = audiencepercents[i];
                        break;
                    }
                }  
                for (int i = 0; i < 4; i++)
                {
                    if (audiencepercents[i] == 0)
                    {
                        audiencepercents[i] = 100 - (percent1 + percent2 + percent3);
                        break;
                    }
                }
            }
            else
            {
                int percent1 = rand.Next(50, 100);
                audiencepercents[(int)char.Parse(answers[level - 1][4]) - 65] = percent1;
                int percent2 = 100 - percent1;
                audiencepercents[(int)char.Parse(answers[level - 1][5]) - 65] = percent2;
            }
            lifeline.BackgroundImage = Properties.Resources.audiencelifeline;
            lifelinetext.BackColor = Color.FromArgb(1, 48, 130);
            lifelinetext.Size = new Size(126, 41);
            lifelinetext.Location = new Point(82, 147);
            lifelinetext.Text = audiencepercents[0] + "% " + audiencepercents[1] + "% " + audiencepercents[2] + "% " + audiencepercents[3] + "%";
            phoneafriend.Enabled = false;
            phoneafriend.BackgroundImage = Properties.Resources.audiencex;
        }

        private void WalkingAway(object sender, EventArgs e)
        {
            fiftyfifty.Enabled = false;
            askthaudience.Enabled = false;
            phoneafriend.Enabled = false;
            walkingaway.Enabled = false;
            otkaz = level;
            announce.Text = "Вие се отказахте от играта си в \"Стани богат\" и си тръгвате с " + amounts[15 - level + 1] + " лева!";
        }

        private void AnswerReveal(object sender, EventArgs e)
        {
            if ((answers[level - 1])[4] == "A")
            {
                answerAbox.Image = Properties.Resources.left_correct;
                answerA.BackColor = Color.FromArgb(107, 155, 74);
                announceA.BackColor = Color.FromArgb(107, 155, 74);
                answerA.ForeColor = Color.FromArgb(0, 0, 0);
                announceA.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if ((answers[level - 1])[4] == "B")
            {
                answerBbox.Image = Properties.Resources.right_correct;
                answerB.BackColor = Color.FromArgb(107, 155, 74);
                announceB.BackColor = Color.FromArgb(107, 155, 74);
                answerB.ForeColor = Color.FromArgb(0, 0, 0);
                announceB.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if ((answers[level - 1])[4] == "C")
            {
                answerCbox.Image = Properties.Resources.left_correct;
                answerC.BackColor = Color.FromArgb(107, 155, 74);
                announceC.BackColor = Color.FromArgb(107, 155, 74);
                answerC.ForeColor = Color.FromArgb(0, 0, 0);
                announceC.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if ((answers[level - 1])[4] == "D")
            {
                answerDbox.Image = Properties.Resources.right_correct;
                answerD.BackColor = Color.FromArgb(107, 155, 74);
                announceD.BackColor = Color.FromArgb(107, 155, 74);
                answerD.ForeColor = Color.FromArgb(0, 0, 0);
                announceD.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if (otkaz == level)
            {
                answerreveal.Enabled = false;
                answerreveal.Visible = false;
                continuegame.Enabled = false;
                continuegame.Visible = false;
                announce.Text = "Вие се отказахте от играта си в \"Стани богат\" и си тръгвате с " + amounts[15 - level + 1] + " лева!";
            }
            if ((answers[level - 1])[4] == finalanswer && otkaz != level)
            {
                answerreveal.Enabled = false;
                answerreveal.Visible = false;
                continuegame.Enabled = true;
                continuegame.Visible = true;
                announce.Text = "Верен отговор!";
                if (level == 5) announce.Text = "Верен отговор! Вече имате първа сигурна сума от 500 лева!";
                if (level == safetynet && safetynet > 5) announce.Text = "Верен отговор! Вече имате втора сигурна сума от " + amounts[15 - safetynet] + " лева!";
            }
            if ((answers[level - 1])[4] == finalanswer && otkaz != level && level == 15)
            {
                answerreveal.Enabled = false;
                answerreveal.Visible = false;
                continuegame.Enabled = false;
                continuegame.Visible = false;
                announce.Text = "Верен отговор! Поздравления - печелите голямата награда от 100 000 лева!";
                this.BackColor = Color.Goldenrod;
            }
            if ((answers[level - 1])[4] != finalanswer && otkaz != level)
            {
                answerreveal.Enabled = false;
                answerreveal.Visible = false;
                continuegame.Enabled = false;
                continuegame.Visible = false;
                announce.Text = "Грешен отговор! Тръгвате си с " + amounts[15 - safetynet] + " лева.";
                if (level < 6) announce.Text = "Грешен отговор! Тръгвате си с 0 лева.";
                this.BackColor = Color.Red;
            }
        }

        private void ContinueTheGame(object sender, EventArgs e)
        {
            answerAbox.Image = Properties.Resources.left;
            answerA.BackColor = Color.FromArgb(14, 48, 121);
            announceA.BackColor = Color.FromArgb(14, 48, 121);
            answerA.ForeColor = Color.White;
            announceA.ForeColor = Color.Gold;
            answerBbox.Image = Properties.Resources.right;
            answerB.BackColor = Color.FromArgb(14, 48, 121);
            announceB.BackColor = Color.FromArgb(14, 48, 121);
            answerB.ForeColor = Color.White;
            announceB.ForeColor = Color.Gold;
            answerCbox.Image = Properties.Resources.left;
            answerC.BackColor = Color.FromArgb(14, 48, 121);
            announceC.BackColor = Color.FromArgb(14, 48, 121);
            answerC.ForeColor = Color.White;
            announceC.ForeColor = Color.Gold;
            answerDbox.Image = Properties.Resources.right;
            answerD.BackColor = Color.FromArgb(14, 48, 121);
            announceD.BackColor = Color.FromArgb(14, 48, 121);
            answerD.ForeColor = Color.White;
            announceD.ForeColor = Color.Gold;
            level++;
            if (level > 5 && safetynet == 5)
            {
                question.Text = "";
                announce.Text = "Заключвате ли " + amounts[15 - level] + " лева като втора сигурна сума?";
                answerA.Text = "Да";
                answerB.Text = "Не";
                answerC.Text = "";
                answerD.Text = "";
                continuegame.Enabled = false;
                continuegame.Visible = false;
                answerAbox.Enabled = true;
                answerBbox.Enabled = true;
                if (level == 6) this.BackColor = Color.FromArgb(0, 102, 204);
            }
            else
            {
                question.Text = questions[level - 1];
                announce.Text = "Въпрос #" + level + " за " + amounts[15 - level] + " лева:";
                if (level == 5) announce.Text = "Въпрос #" + level + " за първа сигурна сума от " + amounts[15 - level] + " лева:";
                if (level == safetynet && safetynet > 5) announce.Text = "Въпрос #" + level + " за втора сигурна сума от " + amounts[15 - level] + " лева:";
                answerA.Text = answers[level - 1][0];
                answerB.Text = answers[level - 1][1];
                answerC.Text = answers[level - 1][2];
                answerD.Text = answers[level - 1][3];
                continuegame.Enabled = false;
                continuegame.Visible = false;
                answerAbox.Enabled = true;
                answerBbox.Enabled = true;
                answerCbox.Enabled = true;
                answerDbox.Enabled = true;
                fiftyfifty.Enabled = true;
                askthaudience.Enabled = true;
                phoneafriend.Enabled = true;
                walkingaway.Enabled = true;
                if (level == safetynet + 1) this.BackColor = Color.FromArgb(0, 0, 64);
            }
        }

        private void ToTheQuestion(object sender, EventArgs e)
        {
            answerAbox.Image = Properties.Resources.left;
            answerA.BackColor = Color.FromArgb(14, 48, 121);
            announceA.BackColor = Color.FromArgb(14, 48, 121);
            answerA.ForeColor = Color.White;
            announceA.ForeColor = Color.Gold;
            answerBbox.Image = Properties.Resources.right;
            answerB.BackColor = Color.FromArgb(14, 48, 121);
            announceB.BackColor = Color.FromArgb(14, 48, 121);
            answerB.ForeColor = Color.White;
            announceB.ForeColor = Color.Gold;
            question.Text = questions[level - 1];
            announce.Text = "Въпрос #" + level + " за " + amounts[15 - level] + " лева:";
            if (level == safetynet) announce.Text = "Въпрос #" + level + " за втора сигурна сума от " + amounts[15 - level] + " лева:";
            answerA.Text = answers[level - 1][0];
            answerB.Text = answers[level - 1][1];
            answerC.Text = answers[level - 1][2];
            answerD.Text = answers[level - 1][3];
            tothequestion.Enabled = false;
            tothequestion.Visible = false;
            answerAbox.Enabled = true;
            answerBbox.Enabled = true;
            answerCbox.Enabled = true;
            answerDbox.Enabled = true;
            fiftyfifty.Enabled = true;
            askthaudience.Enabled = true;
            phoneafriend.Enabled = true;
            walkingaway.Enabled = true;
        }
    }
}