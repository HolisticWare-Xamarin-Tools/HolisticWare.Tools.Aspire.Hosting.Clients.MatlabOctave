using System.Diagnostics;
using Microsoft.IdentityModel.Tokens;

namespace HolisticWare.Tools.Aspire.Hosting.Clients.MatlabOctave;

public partial class 
                                        SettingsMatlabOctave
{
    public static
        string?
                                        Executable
    {
        get;
        set;
    }

    public static
        Dictionary<string, string>
                                        Data 
                                        = new Dictionary<string, string>();

    static
                                        SettingsMatlabOctave
                                        (
                                        )
    {
        /*
        try
        {
            Process.Start("matlab", new string []{} );
            Data.Add("Executable.Matlab", "matlab");
            Executable = "matlab";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        try
        {
            Process.Start("octave", new string []{} );
            Data.Add("Executable.Octave", "octave");

            if (!Data.ContainsKey("Executable.Matlab") || Data["Executable.Matlab"].IsNullOrEmpty())
            {
                Executable = "octave";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        */
        return;
    }
}