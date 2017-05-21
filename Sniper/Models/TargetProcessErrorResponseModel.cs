using System.Net;

namespace Sniper
{
    public class TargetProcessErrorResponseModel
    {
        public HttpStatusCode Status { get; set; }
        public string ErrorId { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DetailData Details { get; set; }

        public class DetailData
        {
            public ItemData[] Items { get; set; }

            public class ItemData
            {
                public string Type { get; set; }
                public string Resolution { get; set; }
                public FieldPathData FieldPath { get; set; }
                public MessageData Message { get; set; }

                public class FieldPathData
                {
                    public string Column { get; set; }
                    public string EntityKind { get; set; }
                }

                public class MessageData
                {
                    public object Data { get; set; }
                    public string Token { get; set; }
                    public string Value { get; set; }
                }
            }
        }
    }
}
