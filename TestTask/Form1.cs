using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Threading;

namespace TestTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string folderName;
        private List<String> wordsForText;

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();

                // если папка выбрана и нажата клавиша `OK` - значит можно получить путь к папке
                if (result == DialogResult.OK)
                {
                    // запишем в нашу переменную путь к папке
                    folderName = folderBrowserDialog1.SelectedPath;
                    folderNameTB.Text = folderName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //нужно создать n файлов, filesNumberNumericUpDown.text, в цикле создаем файлы с именем i.txt
        //где i - счетчик
        public void GenerateFiles()
        {
            try
            { 
                int filesNumber = Convert.ToInt32(filesNumberNumericUpDown.Value);
                for (int i = 0; i < filesNumber; i++)
                {
                    string filePath = string.Format("{0}/{1}.txt", folderName, i);
                    var texts = new string[filesNumber];
                    using (StreamWriter fileStream = File.Exists(filePath) ? File.CreateText(filePath) : File.CreateText(filePath))
                    {
                        var text = GenerateText();
                        fileStream.WriteLine(text);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GenerateText()
        {
            Thread.Sleep(10);
            var separators = new List<String>
            {
                " ", "," ,"." ,"!" ,"?" ,"-", ";", ":"
            };
            int minWords = Convert.ToInt32(minWordsNumericUpDown.Value);
            int maxWords = Convert.ToInt32(maxWordsNumericUpDown.Value);
            var random = new Random();
            int wordsNumber = random.Next(minWords, maxWords);
            string text = null;
            for(int i = 0; i < wordsNumber; i++)
            {
                int wordIndex = random.Next(0,wordsForText.Count);
                text += wordsForText[wordIndex];
                int separatorIndex = random.Next(0, separators.Count);
                text += separators[separatorIndex];
            }
            return text;
        }

        public List<String> ReadFile()
        {
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(appDir, "Text\\RUS.txt");

            List<String> slova = new List<string>();
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                while (!sr.EndOfStream)
                    slova.Add(sr.ReadLine());
            }

            return slova;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(folderNameTB.Text))
            {
                MessageBox.Show("Укажите папку для генерации файлов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt32(minWordsNumericUpDown.Value) > Convert.ToInt32(maxWordsNumericUpDown.Value))
            {
                MessageBox.Show("Минимальное количество слов не может превышать максимальное количество слов в тексте",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(filesNumberNumericUpDown.Value) <=0)
            {
                MessageBox.Show("Нужно сгенерировать хотя бы 1 файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (wordsForText == null)
                    {
                        wordsForText = ReadFile();
                    }
                    GenerateFiles();
                    DialogResult result = MessageBox.Show("Файлы успешно созданы", "Успех!", MessageBoxButtons.OK);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString(),"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                e.Cancel = true;
        }
       
    }
}
