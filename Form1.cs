namespace WinFormsApp10
{

    public partial class Form1 : Form
    {

        private string[][] questionsAndAnswers =
 {
    new[] {"������� �������?", "������", "������", "�����"},
    new[] {"������� ��������?", "������", "������", "�����"},
    new[] {"������� �������?", "��������", "������", "���"},
    new[] {"������� ������?", "����", "������", "���"},
    new[] {"������� �������?", "����", "��������", "����"},
    new[] {"������� ���������?", "����������", "����", "��������"},
    new[] {"������� ��������������?", "������", "������", "��������"},
    new[] {"������� ��������?", "������", "�������", "������"},
    new[] {"������� ����������?", "������", "��������", "���������"},
    new[] {"������� �����������?", "��������", "���������", "���������"},
    new[] {"������� �������?", "���������", "��������", "����������"},
    new[] {"������� �����������?", "��������", "���������", "����������"},
    new[] {"������� ������?", "�����-���������", "������", "�����������"},
    new[] {"������� ��������?", "������-�����", "���-��-�������", "��������"},
    new[] {"������� ���������?", "������", "��������", "��������"}
};


        private int[] correctAnswers = { 2, 0, 1, 2, 0, 1, 0, 2, 1, 1, 1, 2, 1, 2, 2 };
       
        private int currentQuestionIndex = 0;
        private int totalScore = 0;

        public Form1()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questionsAndAnswers.Length)
            {
                label1.Text = questionsAndAnswers[currentQuestionIndex][0];
                comboBox1.Items.Clear();
                for (int i = 1; i < questionsAndAnswers[currentQuestionIndex].Length; i++)
                {
                    comboBox1.Items.Add(questionsAndAnswers[currentQuestionIndex][i]);
                }
            }
            else
            {
                MessageBox.Show($"���� ��������! ��� ����: {totalScore}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questionsAndAnswers.Length)
            {
                if (comboBox1.SelectedIndex == correctAnswers[currentQuestionIndex]
)
                {
                    totalScore++;
                }

                currentQuestionIndex++;

                if (currentQuestionIndex < questionsAndAnswers.Length)
                {
                    LoadQuestion();
                }
                else
                {
                    MessageBox.Show($"���� ��������! ��� ����: {totalScore}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

  
}