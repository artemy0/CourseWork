using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class DragPanel : MonoBehaviour //класс панели перетягиваемых элементов
{

    [Tooltip("Ссылка на префаб драгуемого элемента")]
    [SerializeField] private GameObject dragColorPrefab;

    [Tooltip("Ссылка на Content ScrollView")]
    [SerializeField] private Transform scrollViewContent;

    [Tooltip("Спрайты для перекраски объектов")]
    [SerializeField] private List<Sprite> sprites;

    private void Start()
    {
        for (int i = 0; i < sprites.Count; ++i) //заполнения панели перетягиваемыми элементами
        {
            var dragObject = Instantiate(dragColorPrefab, scrollViewContent);
            var script = dragObject.GetComponent<DragElement>();

            script.MainSprite = sprites[i];
            script.DefaultParentTransform = scrollViewContent;
            script.DragParentTransform = transform;
            script.SiblingIndex = i;
        }
    }

}
