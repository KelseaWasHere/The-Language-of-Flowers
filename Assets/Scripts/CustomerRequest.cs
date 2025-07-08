using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomerRequest
{
    public List<string> preferredColors;
    public List<string> preferredTypes; // romance, grief, etc.
    public List<string> vibes; // e.g., calm, tradition, mystery, etc.

    // Optional: weightings, strictness, etc.
}
