namespace clean_arch.src.Domain.ValueObjects;

using System.ComponentModel.DataAnnotations;

public class Email
{
    [EmailAddress]
    public string Value { get; private set; }

    public Email(string email)
    {
        try { ValidateEmail(email); }
        catch { throw new ArgumentException("Invalid e-mail."); }

        Value = email;
    }
    public override string ToString() => Value;

    private bool ValidateEmail(string email)
    {
        var emailAttribute = new EmailAddressAttribute();
        if (!emailAttribute.IsValid(email))
        {
            return false;
        }

        return true;
    }

}
