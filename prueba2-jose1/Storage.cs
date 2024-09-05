

namespace prueba2_jose1
{
    public class Storage
    {
        #region Variables
        public string StorageName { set; get; }
        public string UbicationStorage { set; get; }
        #endregion


        #region builder
        public Storage() { }
        public Storage(string storageName, string StorageUbication)
        {
            StorageName=storageName;
            UbicationStorage=StorageUbication;
        }
        #endregion


    }
}
