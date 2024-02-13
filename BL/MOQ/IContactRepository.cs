namespace BL.MOQ
{
    public interface IContactRepository
    {
        Contact GetContact(int contactId);
        Contact GetContact(string Name);
        Task<Contact> GetContactAsync(int contactId);

        List<Contact> GetContacts();
        Task<List<Contact>> GetContactsAsync();

        List<Contact> GetContacts(string firstName, string lastName);
        Task<List<Contact>> GetContactsAsync(string firstName, string lastName);

        bool DeleteContact(Contact contact);
        Task<bool> DeleteContactAsync(Contact contact);

        IEnumerable<Contact> BulkUpdate(IEnumerable<Contact> contacts);


    }
}