using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    public class JsonRoomMessage : JsonGeneralPurposeObject 
    {
        public JsonRoomMessage(JToken json) : base(json)
        {
        }
        public new static JsonRoomMessage FromToken(JToken token)
        {
            var instance = new JsonRoomMessage(token);
            return instance;
        }
    }
}