using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZashitaInformacii4Lab
{
    public partial class mainForm : Form
    {
        private Vizhiner message = new Vizhiner();

        public mainForm()
        {
            InitializeComponent();
        }

        // дешифрование 
        private void button2_Click(object sender, EventArgs e)
        {
            if (key.Text != "")
            {
                message.Key = key.Text;
                message.ShifrMessage = shifrMessageTxtBox.Text;
                message.decryption();
                if (message.Error)
                {
                    MessageBox.Show(message.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    messageTxtBox.Text = "";
                    return;
                }
                messageTxtBox.Text = message.MessageText;
            }
            else MessageBox.Show("Не задан ключ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void keyLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void generateKey_Click(object sender, EventArgs e)
        {
            if (keyLength.Text != "")
            {
                message.generateKey(Convert.ToInt32(keyLength.Text));
                key.Text = message.Key;
            }
            else MessageBox.Show("Задайте длину ключа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // шифрование
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (key.Text != "")
            {
                message.Key = key.Text;
                message.MessageText = messageTxtBox.Text;
                message.encryption();
                if (message.Error)
                {
                    MessageBox.Show(message.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    shifrMessageTxtBox.Text = "";
                    return;
                }
                shifrMessageTxtBox.Text = message.ShifrMessage;
            }
            else MessageBox.Show("Не задан ключ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void shifrMessageTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (key.Text != "")
                {
                    message.ShifrMessage = shifrMessageTxtBox.Text;
                    message.decryption();
                    deshifrMessageTxtBox.Text = message.MessageText;
                }
            }
            catch { }
        }

        private void open_Click(object sender, EventArgs e)
        {            
            if (sender == openKey)
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    key.Text = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            if (sender == openMessage)
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    messageTxtBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            if (sender == openShifr)
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    shifrMessageTxtBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.Default);    
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (sender == saveKey)
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    System.IO.File.WriteAllText(saveFileDialog.FileName, key.Text, Encoding.Default);
            if (sender == saveMessage)
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    System.IO.File.WriteAllText(saveFileDialog.FileName, messageTxtBox.Text, Encoding.Default);
            if (sender == saveShifr)
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    System.IO.File.WriteAllText(saveFileDialog.FileName, shifrMessageTxtBox.Text, Encoding.Default);
        }
    }
}
