using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private readonly SortedList<string, bool> Questions = new SortedList<string, bool>()
        {
            { "SSDs are faster than HDDs", true },
            { "Microsoft owns Github", true },
            { "100 is the ASCII code for \"A\"", false }
        };
        private SortedList<string, bool> PlayerAnswers = new SortedList<string, bool>(); // contains player's answers, to be displayed at the end
        private int QuestionNumber = -1;
        private int Score = 0;

        public Form1()
        {
            InitializeComponent();
            ShowNextQuestion(); // show the 1st question
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (rdoTrue.Checked || rdoFalse.Checked)
            {
                CheckAnswer();
                ShowNextQuestion();
            }
        }

        // advances to the next question, and ends the game if questions are exhausted
        private void ShowNextQuestion()
        {
            QuestionNumber++;

            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<string, bool> question = Questions.ElementAt(QuestionNumber);
                string questionText = question.Key;
                txtQuestion.Text = questionText;

                rdoTrue.Checked = false;
                rdoFalse.Checked = false;
            }
            else
            {
                btnCheckAnswer.Enabled = false;
                btnCheckAnswer.Text = "Quiz over!";
                ShowResults();
                this.Dispose();
            }
        }

        private void CheckAnswer()
        {
            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<string, bool> question = Questions.ElementAt(QuestionNumber);
                bool correctAnswer = question.Value;

                // add the question and the player's answer to the PlayerAnswers sorted list
                if (rdoTrue.Checked)
                {
                    PlayerAnswers.Add(question.Key, true);
                }
                else if (rdoFalse.Checked)
                {
                    PlayerAnswers.Add(question.Key, false);
                }

                // compare the answer to the radio button that has been clicked
                if (correctAnswer == true & rdoTrue.Checked == true)
                {
                    Score++;
                }
                if (correctAnswer == false & rdoFalse.Checked == true)
                {
                    Score++;
                }

                lblScore.Text = $"Score: {Score}";
            }
        }

        private void ShowResults()
        {
            string results = "";

            // build a string that shows the correct answer and the player's answer to each question
            foreach(KeyValuePair<string, bool> question in Questions)
            {
                results += $"\n{question.Key}";
                results += $"\nCorrect answer:{question.Value}";
                results += $"\nYour answer: {PlayerAnswers[question.Key]}\n";
            }

            results += $"\nFinal Score: {Score}"; // add the final score

            MessageBox.Show(results, "Final Results"); // show that string in a message box
        }
    }
}
