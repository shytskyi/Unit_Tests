namespace BL.MOQ.ContactService
{
    public class ContactService
    {
        private readonly IContactRepository _contactDataStore;

        public ContactService(IContactRepository contactDataStore)
        {
            _contactDataStore = contactDataStore;
        }


        public Contact GetContact(int contactId)
        {
            return _contactDataStore.GetContact(contactId);
        }

        public async Task<Contact> GetContactAsync(int contactId)
        {
            return await _contactDataStore.GetContactAsync(contactId);
        }

        public Contact GetContact(string Name)
        {
            return _contactDataStore.GetContact(Name);
        }

        public List<Contact> GetContacts()
        {
            return _contactDataStore.GetContacts();
        }

        public bool DeleteContact(Contact contact)
        {
            if (contact == null)
            {
                return false;
            }

            bool result = _contactDataStore.DeleteContact(contact);

            Contact deletedContact = _contactDataStore.GetContact(contact.Id);

            return result && deletedContact == null;
        }
    }
}
