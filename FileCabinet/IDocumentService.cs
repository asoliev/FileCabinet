namespace FileCabinet
{
    public interface IDocumentService
    {
        void SearchByDocumentNumber();
        void SearchByExpression();
        /*
        1. Ability to search for document cards by a document number.
        2. The results should contain a list of card info which matches search requests.
        3. The card info varies based on the document type.
        4. Document cards are stored in the file system. Naming format is the following: type_#{number}.json
        */
    }
}