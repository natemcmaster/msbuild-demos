using System;
using System.ComponentModel.DataAnnotations;

public class Class1
{
    [Required]
    public string Name { get; set; }

    public string BaseDirectory
    {
        get
        {
// compile constants are same as they were in project.json
#if NETSTANDARD1_3
            return AppContext.BaseDirectory;
#endif
#if NET451
            return AppDomain.CurrentDomain.BaseDirectory;
#endif
        }
    }
}
