using System;
using System.Security.Cryptography;
using System.Text;

namespace SMTPTestingTool.Security
{
    internal class Passwords
    {
        public string Senha { get; private set; }
        public string SenhaHash { get; private set; }

        private const int keySize = 64;
        private const int iterations = 350000;
        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

        public Passwords() { }

        public string DefinirSenha(string senha)
        {
            Senha = senha;
            return Senha;
        }

        public string HashPassword(string senha, out byte[] salt)
        {
            try
            {
                salt = RandomNumberGenerator.GetBytes(keySize);

                var hash = Rfc2898DeriveBytes.Pbkdf2(
                    Encoding.UTF8.GetBytes(senha),
                    salt,
                    iterations,
                    hashAlgorithm,
                    keySize);

                return Convert.ToHexString(hash);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool VerificaSenha(string senha, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(senha, salt, iterations, hashAlgorithm, keySize);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
