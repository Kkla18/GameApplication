using System.Collections;

namespace GameApplication.Models
{
    public class ButtonListModel : IList<ButtonModel>
    {
        public ButtonModel Items { get; set; } = new ButtonModel();
        public ButtonListModel() { }

        public ButtonListModel(ButtonModel items)
        {
            Items = items;
        }

        public int Count => ((ICollection<ButtonListModel>)Items).Count;

        public bool IsReadOnly => ((ICollection<ButtonListModel>)Items).IsReadOnly;

        public ButtonModel this[int index] { get => ((IList<ButtonModel>)Items)[index]; set => ((IList<ButtonModel>)Items)[index] = value; }

        public int IndexOf(ButtonModel item)
        {
            return ((IList<ButtonModel>)Items).IndexOf(item);
        }

        public void Insert(int index, ButtonModel item)
        {
            ((IList<ButtonModel>)Items).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<ButtonModel>)Items).RemoveAt(index);
        }

        public void Add(ButtonModel item)
        {
            ((ICollection<ButtonModel>)Items).Add(item);
        }

        public void Clear()
        {
            ((ICollection<ButtonModel>)Items).Clear();
        }

        public bool Contains(ButtonModel item)
        {
            return ((ICollection<ButtonModel>)Items).Contains(item);
        }

        public void CopyTo(ButtonModel[] array, int arrayIndex)
        {
            ((ICollection<ButtonModel>)Items).CopyTo(array, arrayIndex);
        }

        public bool Remove(ButtonModel item)
        {
            return ((ICollection<ButtonModel>)Items).Remove(item);
        }

        public IEnumerator<ButtonModel> GetEnumerator()
        {
            return ((IEnumerable<ButtonModel>)Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Items).GetEnumerator();
        }
    }
}
