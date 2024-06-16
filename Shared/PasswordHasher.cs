namespace HotelBookingAPI.Shared;

public class PasswordHasher
{
    public static string HashPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Password cannot be null or empty.", nameof(password));
        }

        string salt = BCrypt.Net.BCrypt.GenerateSalt();
        string passwordWithSalt = password + salt;

        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordWithSalt, salt);
        string combinedHashedPassword = salt + ":" + hashedPassword;

        return combinedHashedPassword;
    }

    public static bool VerifyPassword(string enteredPassword, string storedHashedPassword)
    {
        if (string.IsNullOrEmpty(enteredPassword) || string.IsNullOrEmpty(storedHashedPassword))
        {
            return false; // Consider throwing an exception or logging this case for further investigation
        }

        // Split the stored hashed password (salt:hash)
        string[] parts = storedHashedPassword.Split(':');
        if (parts.Length != 2)
        {
            // Invalid stored hashed password format
            return false;
        }

        string salt = parts[0];
        string storedHash = parts[1];

        // Combine entered password and retrieved salt
        string passwordWithSalt = enteredPassword + salt;

        // Hash the combined string using BCrypt.Net (same algorithm)
        string enteredPasswordHashed = BCrypt.Net.BCrypt.HashPassword(passwordWithSalt, salt);

        // Compare the newly generated hash with the stored hash
        return BCrypt.Net.BCrypt.Verify(enteredPasswordHashed, storedHash);
    }
}
