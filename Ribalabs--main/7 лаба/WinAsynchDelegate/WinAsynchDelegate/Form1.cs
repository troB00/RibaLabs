using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsynchDelegate
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int seconds) || seconds <= 0)
            {
                MessageBox.Show("Введите положительное число");
                return;
            }

            button1.Enabled = false;  
            button2.Enabled = true;    
            progressBar1.Value = 0;    

            cts = new CancellationTokenSource();

            try
            {
                await Task.Run(() => TimeConsumingMethod(seconds, cts.Token), cts.Token);
                MessageBox.Show("Операция завершена успешно");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция отменена");
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                cts?.Dispose();
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void TimeConsumingMethod(int seconds, CancellationToken token)
        {
            for (int j = 1; j <= seconds; j++)
            {
                token.ThrowIfCancellationRequested();

                int progress = (int)(j * 100) / seconds;
                SetProgress(progress);

                Thread.Sleep(1000); 
            }
        }

        private void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action<int>(SetProgress), val);
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать только цифры");
            }
        }
    }
}