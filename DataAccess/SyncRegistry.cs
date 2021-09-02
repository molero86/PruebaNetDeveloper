using System;

namespace DataAccess
{
    public class SyncRegistry
    {
        public SyncRegistry()
        {

        }

        public SyncRegistry(string serializedRegistry)
        {
            //TODO(R): Meter en una variable el split
            var array = serializedRegistry.Split("$%&");

            Date = DateTime.Parse(array[0]);
            Text = array[1];
        }

        public DateTime Date { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return string.Format("{0}$%&{1}", Date, Text);
        }
    }
}
