using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace XREngine.RealityPack
{
    public class RPComponent : MonoBehaviour
    {
        public virtual string Type => "realitypack";

        public virtual JProperty Serialized => null;
    }

}
