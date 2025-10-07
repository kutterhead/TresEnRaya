using UnityEngine;

public class TresEnRaya : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]int[] celdasValor = new int[9];

    [SerializeField] bool turnoOX = false;


    int tirada = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void actualizaCasilla(boton3raya scriptBoton)
    {





        int indice = scriptBoton.indice;

        if (celdasValor[indice] != 0)
        {
            return;
        }

        

        if (turnoOX==false)
        {

            celdasValor[indice] = 1;//valor O
            scriptBoton.textMeshPro.text = "O";
        }
        else
        {
            celdasValor[indice] = 2;// valor X
            scriptBoton.textMeshPro.text = "X";


        }
        compruebaLinea();
        turnoOX = !turnoOX;
        tirada++;
    }
    
    public void compruebaLinea()
    {

        bool detectadaLinea = true;

        int jugador12 = 0;

        if (turnoOX==false)
        {

            jugador12 = 1;

        }
        else
        {

            jugador12= 2;
        }



            //filas
            for (int i = 0; i < celdasValor.Length; i += 3)
            {

                detectadaLinea = (celdasValor[i] == jugador12) && (celdasValor[i + 1] == jugador12) && (celdasValor[i + 2] == jugador12);

                if (detectadaLinea)
                {

                    Debug.Log("detectada linea Horizontal player: " + jugador12);
                    return;
                    //break;
                }



            }



        for (int i = 0; i < 3; i++)
        {

            detectadaLinea = (celdasValor[i] == jugador12) && (celdasValor[i + 3] == jugador12) && (celdasValor[i + 6] == jugador12);

            if (detectadaLinea)
            {

                Debug.Log("detectada linea vertical player: " + jugador12);
                break;
            }



        }





    }

}
