using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    // will hold all our CRUD
    public class StreamingContentRepository
    {
        // A Field
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();
        // This will be a variable that can be used inside of all the other methods.

        // Create
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
            // the underscore is meant to represent a field. This is meant to help quickly associate what is a field, property, etc.

        }

        // Read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
            // when calling this method, we can access this list.
        }

        // Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            // Find the Content
            StreamingContent oldContent = GetContentByTitle(originalTitle);


            // Update the Content
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;

                return true;
            } 
            else
            {
                return false;
            }
        }

        // Delete
        public bool RemoveContentFromlist(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if( content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count; // this should provide us a number of items in our list.
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper Method
        // To help the other methods complete their tasks
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title == title)
                {
                    return content;
                }
            }

            return null;
        }
    }
}
