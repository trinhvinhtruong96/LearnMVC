using WebApp.Data.Enums;

namespace WebApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}