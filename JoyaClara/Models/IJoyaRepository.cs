namespace JoyaClara.Models
{
    public interface IJoyaRepository
    {
        IEnumerable<Joya> AllJoyas { get; }
        IEnumerable<Joya> JoyasOfTheWeek { get; }
        Joya? GetJoyaById(int joyaId);
    }
}
