using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TagListType
{
    Blacklist,
    Whitelist
}

public class DestroyedOnCollision : MonoBehaviour
{
    [SerializeField] private TagListType tagListType = TagListType.Blacklist; // A list of tags which we use to determine whether to explode or not
    [SerializeField] private List<string> tags; // Depending on the tagListType (Blacklist or Whitelist)

    void OnTriggerEnter2D(Collider2D other)
    {
        bool tagInList = tags.Contains(other.gameObject.tag);

        if (tagListType == TagListType.Blacklist && tagInList)
        {
            Destroy(gameObject); // Destroy if it's a Blacklist and the tag IS in the Blacklist
        }
       
        else if (tagListType == TagListType.Whitelist && !tagInList)
        {
            Destroy(gameObject); // Destroy if it's a Whitelist and the tag is NOT in the Whitelist
        }
    
        else
        {
            // Use default collision code
            Destroy(gameObject);
        }
    }
}
