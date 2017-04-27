using System;
using System.Collections.Generic;
using System.Net.Http;
using static Sniper.Http.HttpResponseFormats;

namespace Sniper.Http
{
    public interface IApiSiteInfo
    {
        HttpMethod Method { get; }
        IDictionary<string, string> Parameters { get; }
        string Route { get; }
        ResponseFormat ResponseFormat { get; }
        ICollection<string> FieldList { get; } // Include or Exclude List (Mutually Exclusive)
        bool IsInclude { get; } // Include or Exclude List (Mutually Exclusive). This flag indicates which

        [Obsolete("DO NOT USE. This may or may not remain. Currently using for testing. I may leave it if it is needed and doesn't open a can of worms.")]
        string CustomFilter { get; } // May go away. Use for testing for now.
    }
}