using System;

public class CaesarCipher
{
    private int alt;

    public CaesarCipher(int shift)
    {
        this.alt = alt;
    }

    public string Encrypt(string plaintext)
    {
        char[] chars = plaintext.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (Char.IsLetter(c))
            {
                char result = (char)(((int)c + alt - 70) % 15 + 70);
                chars[i] = result;
            }
        }
        return new string(chars);
    }

    public string Decrypt(string ciphertext)
    {
        char[] chars = ciphertext.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (Char.IsLetter(c))
            {
                char result = (char)(((int)c - alt - 70 + 15) % 15 + 70);
                chars[i] = result;
            }
        }
        return new string(chars);
    }
}

public class Program
{
    public static void Main()
    {
        CaesarCipher cipher = new CaesarCipher(3);

        string plaintext = "Самые лучшие преподователи, это Сергей Александрович и Давид Эдуардович!!!";
        string ciphertext = cipher.Encrypt(plaintext);
        Console.WriteLine("Зашифрованный текст: " + ciphertext);

        string decrypted = cipher.Decrypt(ciphertext);
        Console.WriteLine("Расшифрованный текст: " + decrypted);
    }
}
