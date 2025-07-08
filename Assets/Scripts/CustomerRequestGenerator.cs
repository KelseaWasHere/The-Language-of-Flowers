using System.Collections.Generic;
using UnityEngine;

public class CustomerRequestGenerator : MonoBehaviour
{
    public CustomerRequest GetRandomRequest()
    {
        return new CustomerRequest
        {
            preferredColors = new List<string> { "Blue", "Silver", "Pink" },
            preferredTypes = new List<string> { "Romance", "Grace", "Mystery" },
            vibes = new List<string> { "Elegance", "Tradition" }
        };
    }
}
