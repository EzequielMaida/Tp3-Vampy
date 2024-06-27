using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Camara : MonoBehaviour
{
    public static Camara Instancia;
    public float duracion, fuerza;

    private void Awake()
    {
        Camara.Instancia = this;
    }
    public void ScreenShake()
    {
        transform.DOShakePosition(duracion, fuerza)
        .OnComplete(() => transform.position = new Vector3(0, 0, -10));
    }
}
