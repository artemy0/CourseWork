using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class DragElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    [SerializeField] private Image mainImage;

    private Sprite mainSprite;
    /// <summary>
    /// Материал, применяемый к объектам на сцене
    /// </summary>
    public Sprite MainSprite
    {
        get { return mainSprite; }
        set
        {
            if (value != null)
            {
                mainSprite = value;
                if (mainImage != null)
                    mainImage.sprite = mainSprite;
            }
        }
    }

    private Transform defaultParentTransform;
    /// <summary>
    /// Трансформ объекта, к которому прикреплена кнопка
    /// </summary>
    public Transform DefaultParentTransform
    {
        get { return defaultParentTransform; }
        set
        {
            if (value != null)
            {
                defaultParentTransform = value;
            }
        }
    }

    private Transform dragParentTransform;
    /// <summary>
    /// Трансформ объекта, к которому прикрепляется кнопка во время драга
    /// </summary>
    public Transform DragParentTransform
    {
        get
        {
            return dragParentTransform;
        }
        set
        {
            if (value != null)
                dragParentTransform = value;
        }
    }

    private int siblingIndex;
    /// <summary>
    /// Номер индекса внутри родительского объекта
    /// </summary>
    public int SiblingIndex
    {
        get { return siblingIndex; }
        set
        {
            if (value > 0)
                siblingIndex = value;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(DragParentTransform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, 1));
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //возвращаем обратно в контент элемент
        transform.SetParent(DefaultParentTransform);
        transform.SetSiblingIndex(SiblingIndex);

        //создаем луч и хит
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //пускаем луч и меняем материал у встреченного объекта
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log("Объект найден");
            hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite = mainSprite;

            hit.collider.gameObject.GetComponent<CosmeticSelectedElement>().ToDetermine();//jgh
        }
    }

}
