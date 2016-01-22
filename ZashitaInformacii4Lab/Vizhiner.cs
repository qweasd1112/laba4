using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZashitaInformacii4Lab
{
    class Vizhiner
    {
        private string message;
        private string shifrMessage;
        private char[] key;
        private char[] alphabet;
        private int alphabetLength;
        private bool error;
        private string errorMessage;

        public Vizhiner()
        {
            alphabet = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                                   'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                   'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж',
                                   'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 
                                   'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н',
                                   'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', ' ', '.', 
                                   ',', '!', '-', '?', '+', '=', '~', '"', '@', '#', '*', '/', ':', ';', '%', '^', '&', '(', ')', '_',
                                   '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '$', '\n', '\r', '\\'};
            alphabetLength = alphabet.Length;
        }

        public string MessageText
        {
            get { return message; }
            set { message = value; }
        }

        public int AlphabetLength
        {
            get { return alphabetLength; }
        }

        public string ShifrMessage
        {
            get { return shifrMessage; }
            set { shifrMessage = value; }
        }

        public string Key
        {
            get
            {
                string temp = "";
                for (int i = 0; i < key.Length; i++)
                    temp += key[i].ToString();
                return temp;
            }
            set
            {
                key = null;
                key = new char[value.Length];
                for (int i = 0; i < value.Length; i++)
                    key[i] = value[i];
            }
        }

        public bool Error
        {
            get { return error; }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
        }
        
        // шифрование
        public void encryption()
        {
            error = false;
            shifrMessage = "";
            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                int messageCharIndex = getIndex(message[i]);
                int keyCharIndex = getIndex(key[j]);
                if (messageCharIndex == -1)
                {
                    error = true;
                    errorMessage = "Символ сообщения '" + message[i] + "' (индекс " + i.ToString() + ") не принадлежит алфавиту.";
                    return;
                }
                if (keyCharIndex == -1)
                {
                    error = true;
                    errorMessage = "Символ ключа '" + key[j] + "' (индекс " + j.ToString() + ") не принадлежит алфавиту.";
                    return;
                }
                shifrMessage += alphabet[(messageCharIndex + keyCharIndex) % alphabetLength];
                j++;
                if (j >= key.Length) j = 0;
            }
        }

        // дешифрование
        public void decryption()
        {
            error = false;
            message = "";
            int j = 0;
            for (int i = 0; i < shifrMessage.Length; i++)
            {
                int shifrMessageCharIndex = getIndex(shifrMessage[i]);
                int keyCharIndex = getIndex(key[j]);
                if (shifrMessageCharIndex == -1)
                {
                    error = true;
                    errorMessage = "Символ зашифрованного сообщения '" + shifrMessage[i] + "' (индекс " + i.ToString() + ") не принадлежит алфавиту.";
                    return;
                }                 
                if (keyCharIndex == -1)
                {
                    error = true;
                    errorMessage = "Символ ключа '" + key[j] + "' (индекс " + j.ToString() + ") не принадлежит алфавиту.";
                    return;
                }
                message += alphabet[(shifrMessageCharIndex - keyCharIndex + alphabetLength) % alphabetLength];
                j++;
                if (j >= key.Length) j = 0;
            }
        }

        public void generateKey(int length)
        {
            RandomGenerator random = new RandomGenerator(alphabetLength);
            key = new char[length];
            for (int i = 0; i < length; i++)
                key[i] = alphabet[random.next()];
        }

        // получение индекса символа в алфавите
        private int getIndex(char ch)
        {
            for (int i = 0; i < alphabetLength; i++)
            {
                if (alphabet[i] == ch)
                    return i;
            }
            return -1; // ch нет в алфавите
        }
    }
}
