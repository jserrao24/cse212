public class PriorityQueue
{
    private List<PriorityItem> _queue = new List<PriorityItem>();

    /// <summary>
    /// Add a new value to the queue with an associated priority.
    /// The node is added to the back of the queue based on priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);

        if (_queue.Count == 0 || priority > _queue[_queue.Count - 1].Priority)
        {
            _queue.Add(newNode);
        }
        else
        {
            int insertIndex = SearchForInsertion(_queue, newNode);
            _queue.Insert(insertIndex, newNode);
        }
    }

    private int SearchForInsertion(List<PriorityItem> queue, PriorityItem item)
    {
        int low = 0;
        int high = queue.Count;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (queue[mid].Priority < item.Priority)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return low;
    }

    public String Dequeue()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        var value = _queue[0].Value;
        _queue.RemoveAt(0);
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}