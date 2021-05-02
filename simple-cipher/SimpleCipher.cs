using System;
using System.Linq;

public class SimpleCipher
{
    private readonly string _key;

    private static string Randomtring(int len) {
        Random random = new Random();
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        return new string (Enumerable.Repeat(chars, len).Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public SimpleCipher() => _key = Randomtring(256);

    public SimpleCipher(string key) => _key = key;

    public string Key { get => _key; }

    private string resizeKey(int len) {
        string key = _key;
        while (key.Length < len)
            key += key;
        return key;
    }

    public string Encode(string plaintext) {
        string key = resizeKey(plaintext.Length);
        return new string(plaintext.Zip(key, (plainChar, encodingChar) =>
            Convert.ToChar('a' + ((plainChar - 'a') + (encodingChar - 'a')) % 26)).ToArray());
    }

    private static int decipherChar(char cipherChar, char encodingChar) => (cipherChar - 'a') - (encodingChar - 'a');

    public string Decode(string ciphertext) {
        string key = resizeKey(ciphertext.Length);
        return new string(ciphertext.Zip(key, (cipherChar, encodingChar) =>
            Convert.ToChar(((decipherChar(cipherChar, encodingChar)) < 0 ?
                            ('z' + decipherChar(cipherChar, encodingChar) + 1) :
                            ('a' + decipherChar(cipherChar, encodingChar))))).ToArray());
    }
}
