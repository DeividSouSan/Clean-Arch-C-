namespace clean_arch.src.Domain.Entities;

using clean_arch.src.Domain.ValueObjects;
public class Registration
{
    private string Name { get; set; }
    private Email Email { get; set; }
    private DateTime BirthDate
    {
        get => BirthDate;
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Invalid birth date.");
            }

            if (value.AddYears(18) > DateTime.Now)
            {
                throw new ArgumentException("Underage.");
            }
        }
    }
    private Cpf RegistrationCode { get; set; }
    private DateTime RegistrationAt { get; set; }

    public Registration(string name, Email email, DateTime birthDate, Cpf registrationCode, DateTime registrationAt)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        RegistrationCode = registrationCode;
        RegistrationAt = registrationAt;
    }
}