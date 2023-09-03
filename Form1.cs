namespace WinFormsApp10
{

    public partial class Form1 : Form
    {

        private string[][] questionsAndAnswers =
 {
    new[] {"Столица Франции?", "Берлин", "Мадрид", "Париж"},
    new[] {"Столица Германии?", "Берлин", "Мадрид", "Париж"},
    new[] {"Столица Испании?", "Лиссабон", "Мадрид", "Рим"},
    new[] {"Столица Италии?", "Вена", "Мадрид", "Рим"},
    new[] {"Столица Австрии?", "Вена", "Будапешт", "Берн"},
    new[] {"Столица Швейцарии?", "Люксембург", "Берн", "Брюссель"},
    new[] {"Столица Великобритании?", "Лондон", "Дублин", "Эдинбург"},
    new[] {"Столица Ирландии?", "Лондон", "Кардифф", "Дублин"},
    new[] {"Столица Португалии?", "Мадрид", "Лиссабон", "Барселона"},
    new[] {"Столица Нидерландов?", "Брюссель", "Амстердам", "Роттердам"},
    new[] {"Столица Бельгии?", "Антверпен", "Брюссель", "Люксембург"},
    new[] {"Столица Люксембурга?", "Брюссель", "Амстердам", "Люксембург"},
    new[] {"Столица России?", "Санкт-Петербург", "Москва", "Новосибирск"},
    new[] {"Столица Бразилии?", "Буэнос-Айрес", "Рио-де-Жанейро", "Бразилиа"},
    new[] {"Столица Австралии?", "Сидней", "Мельбурн", "Канберра"}
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
                MessageBox.Show($"Тест завершен! Ваш балл: {totalScore}");
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
                    MessageBox.Show($"Тест завершен! Ваш балл: {totalScore}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

  
}