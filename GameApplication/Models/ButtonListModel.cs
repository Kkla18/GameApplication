using System.Collections;

namespace GameApplication.Models
{
    public class ButtonListModel : IList<List<ButtonModel>>
    {
        public List<ButtonModel> Items { get; set; } = new List<ButtonModel>();
        public ButtonListModel() { }

        public ButtonListModel(List<ButtonModel> items)
        {
            Items = items;
        }

        public int Count => ((ICollection<ButtonListModel>)Items).Count;

        public bool IsReadOnly => ((ICollection<ButtonListModel>)Items).IsReadOnly;

        public List<ButtonModel> this[int index] { get => ((IList<List<ButtonModel>>)Items)[index]; set => ((IList<List<ButtonModel>>)Items)[index] = value; }

        public int IndexOf(List<ButtonModel> item)
        {
            return ((IList<List<ButtonModel>>)Items).IndexOf(item);
        }

        public void Insert(int index, List<ButtonModel> item)
        {
            ((IList<List<ButtonModel>>)Items).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<List<ButtonModel>>)Items).RemoveAt(index);
        }

        public void Add(List<ButtonModel> item)
        {
            ((ICollection<List<ButtonModel>>)Items).Add(item);
        }

        public void Clear()
        {
            ((ICollection<List<ButtonModel>>)Items).Clear();
        }

        public bool Contains(List<ButtonModel> item)
        {
            return ((ICollection<List<ButtonModel>>)Items).Contains(item);
        }

        public void CopyTo(List<ButtonModel>[] array, int arrayIndex)
        {
            ((ICollection<List<ButtonModel>>)Items).CopyTo(array, arrayIndex);
        }

        public bool Remove(List<ButtonModel> item)
        {
            return ((ICollection<List<ButtonModel>>)Items).Remove(item);
        }

        public IEnumerator<List<ButtonModel>> GetEnumerator()
        {
            return ((IEnumerable<List<ButtonModel>>)Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Items).GetEnumerator();
        }
    }
}
