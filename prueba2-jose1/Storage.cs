namespace prueba2_jose1
{
    public class Storage
    {
        #region Variables

        // Property to store the name of the storage
        public string StorageName { get; set; }

        // Property to store the location of the storage
        public string UbicationStorage { get; set; }

        #endregion

        #region Constructor

        // Default constructor
        public Storage() { }

        /// <summary>
        /// Constructor that initializes the storage with a name and location.
        /// </summary>
        /// <param name="storageName">The name of the storage</param>
        /// <param name="StorageUbication">The location of the storage</param>
        public Storage(string storageName, string StorageUbication)
        {
            StorageName = storageName;
            UbicationStorage = StorageUbication;
        }

        #endregion
    }
}
