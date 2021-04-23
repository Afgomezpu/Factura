using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;
using System;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Threading;

// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.DataTime;


public class Principal : MonoBehaviour
{   ValoresDefecto modificacion;
    public GameObject Nombre;
    public GameObject Direccion;
    public GameObject  fechaFactura;
    public GameObject FacturaDesde;
    public GameObject FacturaHasta;
    public GameObject DiaDefactura;
    public GameObject FacturaMes;
    public GameObject FechaMaximaPago;
    public GameObject FechaSuspencionpago;
    public GameObject ConsumoActiva;
    public GameObject LecturaActual;
    public GameObject LecturaAnterior;
    public GameObject FactorMultiplicacion;
    public GameObject ConsumoReactiva;
    public GameObject LecturaActualReactiva;
    public GameObject LecturaAnteriorReactiva;
    public GameObject FactorMultiplicacionReactiva;
    public TMP_Dropdown Municipio;
    public TMP_Dropdown Estrato;  
    public GameObject TotalKilowatios;
    public GameObject Subsidio;  
    public GameObject KwSubsidiado;
    public GameObject ValorKlSubsidiado;
    public GameObject ValorConsumoconSubsidio;
    public GameObject KwSinSubsidiado;
    public GameObject ValorKlSinSubsidiado;
    public GameObject ValorConsumoSinconSubsidio;
     public GameObject ValorTotalConsumoActivo;   
     public GameObject FechaUltimoPago;
     public GameObject ValorUltimoPago;
     public GameObject TasaInteresMoratorio;
     public GameObject ConsumoActual;
    public GameObject Consumoanterior;   
    public GameObject ConsumoAnteriorDias;
    public GameObject ConsumoActualDias ;
    public GameObject FlechaIncremento;
    public GameObject FlechaBajo;
    public GameObject GraficasCompletos;
    public GameObject Prom1;
    public GameObject promgraf1;
    public GameObject Prom2;
    public GameObject promgraf2;
    public GameObject Prom3;
    public GameObject promgraf3;
    public GameObject Act1;
    public GameObject Actgraf1;
     public GameObject Act2;
    public GameObject Actgraf2;
     public GameObject Act3;
    public GameObject Actgraf3;
     public GameObject Act4;
    public GameObject Actgraf4;
    public GameObject mes1;
    public GameObject mes2;
    public GameObject mes3;
    public GameObject mes4;
    public GameObject mes5;
    public GameObject mes6;
    public GameObject kilmes1;
    public GameObject kilmes2;
    public GameObject kilmes3;
    public GameObject kilmes4;
    public GameObject kilmes5;
    public GameObject kilmes6;
    public GameObject KilowatiosTotales;
    public GameObject TarifaKilowatiosTotales;
    public int valorKilowatiosCompleto;
    public int valorKilowatiosCompletoSinsubsidio;
    public int sumaTotal;
    public GameObject KilowatiosSubsiados;
    public GameObject TarifaKilowatiosSubsidiadosTotales;
    public GameObject ValorServicioEnergia;
    public GameObject MesTarifaria;
    public GameObject TarifaTarifaria;
    public GameObject Generacion;
    public GameObject Trasmision;
    public GameObject Distribucion;
    public GameObject Comercializacion;
    public GameObject Perdidas;
    public GameObject Restricciones;
    public GameObject MesesDeuda;
    public GameObject ValorServicioEnergiaFinal;
    public GameObject ValorservicioTotal;
    public GameObject ValorTotalCreditoSomo;
    public GameObject ValorTotalOtrosProductos; 
    public GameObject ValorTotalImpuestoo;  
    public GameObject ValorTotalAseo; 
    public GameObject ValorSaldosanteriores;
    public GameObject ValorComprasomos;
    public GameObject cuotaComprasomos;
    public GameObject CapitalComprasomos;
    public GameObject segundaaComprasomos;
    public GameObject cuotaFinalComprasomos;
    public GameObject SaldoComprasomos;
    public GameObject TotalComprasomos;
    public GameObject ValorOtros;
    public GameObject ValorFinalOtros;
    public GameObject ValorAseo;
    public GameObject ValorfinalAseo;
    public GameObject Municipio2;
    public GameObject Nombre2;
    public GameObject Cuenta;
    public GameObject Cuenta2;
    public GameObject Saldoanterior2;
    public GameObject Saldoactual1;
    public GameObject ValorTotalSaldo;
    public GameObject PagoSaldo;
    public int prom;
     private string vmunicipio;
     private string vestrato;
     public GameObject Saldoanterior;
    System.DateTime Desde;
    System.DateTime Hasta;
    System.DateTime suspencion;
    System.DateTime pago;
    System.DateTime FechaPago;
    System.TimeSpan Resultado;
    System.String valor;
    string Myformat;
    string prueba;
    string format;
    public GameObject ValorCuotaServicioDeEnergia;
    
    

    void Start()
    {   
       modificacion=FindObjectOfType<ValoresDefecto>();
       print(modificacion.Valor1);
        Myformat=@"dd/MMM/yyyy";
        prueba="12/04/2021";
        valor="11/05/2021";
        DropdownItemSelected1(Municipio);
        DropdownItemSelected2(Estrato);
        Municipio.onValueChanged.AddListener(delegate{DropdownItemSelected1(Municipio);});
        Estrato.onValueChanged.AddListener(delegate{DropdownItemSelected2(Estrato);});
        FactorMultiplicacion.GetComponent<TMP_InputField>().text="1";
        FactorMultiplicacionReactiva.GetComponent<TMP_InputField>().text="1";
        Hasta=System.DateTime.Parse(prueba);
        Desde=System.DateTime.Parse(valor);
        Resultado =Desde.Subtract(Hasta);
        suspencion=Desde.AddDays(21);
        FechaPago=Desde.AddMonths(-1);
    
        print(Hasta.ToString(@Myformat)); 
        print(Hasta.ToString("MMMM")); 
        print(Resultado.ToString("%d"));
        print(suspencion.ToString(@Myformat));
        print(Desde.ToString(@Myformat));
        print(FechaPago.ToString(@Myformat));
        print((FechaPago.ToString("MMM")).ToUpper());
    }

    
    void Update()
    {
        if(Saldoactual1.GetComponent<TMP_InputField>().text!=""){
            ValorTotalImpuestoo.GetComponent<TMP_InputField>().text=Saldoactual1.GetComponent<TMP_InputField>().text;
            if(Saldoanterior2.GetComponent<TMP_InputField>().text!=""){
                ValorTotalSaldo.GetComponent<TextMeshProUGUI>().text=""+Convert.ToInt32(double.Parse(Saldoactual1.GetComponent<TMP_InputField>().text)+
                double.Parse(Saldoanterior2.GetComponent<TMP_InputField>().text));
            }
            else{
               ValorTotalSaldo.GetComponent<TextMeshProUGUI>().text=Saldoactual1.GetComponent<TMP_InputField>().text; 
            }

        }
          if(Nombre.GetComponent<TMP_InputField>().text!=""){
             Nombre2.GetComponent<TextMeshProUGUI>().text=Nombre.GetComponent<TMP_InputField>().text;
          }

          if(Cuenta.GetComponent<TMP_InputField>().text!=""){
             Cuenta2.GetComponent<TextMeshProUGUI>().text=Cuenta.GetComponent<TMP_InputField>().text;
          }  

         if(FacturaDesde.GetComponent<TMP_InputField>().text!="" && FacturaHasta.GetComponent<TMP_InputField>().text!=""){
             Desde=System.DateTime.Parse(FacturaDesde.GetComponent<TMP_InputField>().text);
             Hasta=System.DateTime.Parse(FacturaHasta.GetComponent<TMP_InputField>().text);
             fechaFactura.GetComponent<TextMeshProUGUI>().text=((Desde.ToString(@Myformat)).ToUpper()).Replace(".","");
             DiaDefactura.GetComponent<TextMeshProUGUI>().text=(Desde.Subtract(Hasta)).ToString("%d");
             FacturaMes.GetComponent<TextMeshProUGUI>().text=(Hasta.ToString("MMMM")).ToUpper();
             MesTarifaria.GetComponent<TextMeshProUGUI>().text=(Desde.ToString("MMMM")).ToUpper();
             FechaMaximaPago.GetComponent<TextMeshProUGUI>().text=(((Desde.AddDays(20)).ToString(@Myformat)).ToUpper()).Replace(".","");
             PagoSaldo.GetComponent<TextMeshProUGUI>().text=(((Desde.AddDays(20)).ToString(@Myformat)).ToUpper()).Replace(".","");
             if(Saldoanterior.GetComponent<TMP_InputField>().text!=""){
                 Saldoanterior2.SetActive(true);
                 FechaSuspencionpago.GetComponent<TextMeshProUGUI>().text=(((Desde.AddDays(23)).ToString(@Myformat)).ToUpper()).Replace(".","");
             }
             
             FechaUltimoPago.GetComponent<TextMeshProUGUI>().text=(((Desde.AddDays(-2)).ToString(@Myformat)).ToUpper()).Replace(".","");
             if(Generacion.GetComponent<TMP_InputField>().text!="" && Trasmision.GetComponent<TMP_InputField>().text!=""
             && Distribucion.GetComponent<TMP_InputField>().text!=""&& Comercializacion.GetComponent<TMP_InputField>().text!=""
             && Perdidas.GetComponent<TMP_InputField>().text!=""&& Restricciones.GetComponent<TMP_InputField>().text!=""){
              TarifaTarifaria.GetComponent<TextMeshProUGUI>().text=""+((double.Parse(Generacion.GetComponent<TMP_InputField>().text))+
             (double.Parse(Trasmision.GetComponent<TMP_InputField>().text))+(double.Parse(Distribucion.GetComponent<TMP_InputField>().text))+
             (double.Parse(Comercializacion.GetComponent<TMP_InputField>().text))+(double.Parse(Perdidas.GetComponent<TMP_InputField>().text))+
             (double.Parse(Restricciones.GetComponent<TMP_InputField>().text))) ;  
             }
             
             if((Desde.AddDays(-2)).ToString("MMMM").Equals("enero")||(Desde.AddDays(-2)).ToString("MMMM").Equals("mayo")
             ||(Desde.AddDays(-2)).ToString("MMMM").Equals("septiembre")){
                 ValorUltimoPago.GetComponent<TextMeshProUGUI>().text="80.000";
             }
            else if((Desde.AddDays(-2)).ToString("MMMM").Equals("febrero")||(Desde.AddDays(-2)).ToString("MMMM").Equals("junio")
            ||(Desde.AddDays(-2)).ToString("MMMM").Equals("octubre")){
                  ValorUltimoPago.GetComponent<TextMeshProUGUI>().text="100.000";
             }
             else if((Desde.AddDays(-2)).ToString("MMMM").Equals("marzo")||(Desde.AddDays(-2)).ToString("MMMM").Equals("julio")
             ||(Desde.AddDays(-2)).ToString("MMMM").Equals("noviembre")){
                  ValorUltimoPago.GetComponent<TextMeshProUGUI>().text="56.000";
             }
             else if((Desde.AddDays(-2)).ToString("MMMM").Equals("abril")||(Desde.AddDays(-2)).ToString("MMMM").Equals("agosto")
             ||(Desde.AddDays(-2)).ToString("MMMM").Equals("diciembre")){
                  ValorUltimoPago.GetComponent<TextMeshProUGUI>().text="112.000";
             }
           TasaInteresMoratorio.SetActive(true);
         }

         if(LecturaActual.GetComponent<TMP_InputField>().text!="" && LecturaAnterior.GetComponent<TMP_InputField>().text!=""){
             ConsumoActiva.GetComponent<TextMeshProUGUI>().text="" + ((double.Parse(LecturaActual.GetComponent<TMP_InputField>().text))
             -(double.Parse(LecturaAnterior.GetComponent<TMP_InputField>().text)));
             TotalKilowatios.GetComponent<TextMeshProUGUI>().text="" + (((double.Parse(LecturaActual.GetComponent<TMP_InputField>().text))
             -(double.Parse(LecturaAnterior.GetComponent<TMP_InputField>().text)))*double.Parse(FactorMultiplicacion.GetComponent<TMP_InputField>().text));
               ConsumoActual.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
               ConsumoActualDias.GetComponent<TextMeshProUGUI>().text=DiaDefactura.GetComponent<TextMeshProUGUI>().text;
                Consumoanterior.SetActive(true);   
                ConsumoAnteriorDias.SetActive(true);
                ValorCuotaServicioDeEnergia.SetActive(true);
                GraficasCompletos.SetActive(true);
                KilowatiosTotales.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                
               
                if(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)>=270){
                        Act1.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                        Actgraf1.SetActive(true);
                        Act2.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf2.SetActive(false);
                        Act3.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf3.SetActive(false);
                        Act4.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf4.SetActive(false);
                        
                }
              else if(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)>=200&&double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)<220){
                        Act2.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                        Actgraf2.SetActive(true);
                         Act1.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf1.SetActive(false);
                        Act3.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf3.SetActive(false);
                        Act4.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf4.SetActive(false);
                }
                else if(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)>=220&&double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)<270){
                        Act3.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                        Actgraf3.SetActive(true);
                         Act2.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf2.SetActive(false);
                        Act1.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf1.SetActive(false);
                        Act4.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf4.SetActive(false);
                }
               else if(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)<200){
                        Act4.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                        Actgraf4.SetActive(true);
                         Act2.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf2.SetActive(false);
                        Act3.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf3.SetActive(false);
                        Act1.GetComponent<TextMeshProUGUI>().text="";
                        Actgraf1.SetActive(false);
                }
                prom=Convert.ToInt32((double.Parse(kilmes1.GetComponent<TextMeshProUGUI>().text)+
                double.Parse(kilmes2.GetComponent<TextMeshProUGUI>().text)+
                double.Parse(kilmes3.GetComponent<TextMeshProUGUI>().text)+
                double.Parse(kilmes4.GetComponent<TextMeshProUGUI>().text)+
                double.Parse(kilmes5.GetComponent<TextMeshProUGUI>().text)+
                double.Parse(kilmes6.GetComponent<TextMeshProUGUI>().text)+
                double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text))/7);
                 mes1.GetComponent<TextMeshProUGUI>().text=((Desde.AddMonths(-5)).ToString("MMM")).ToUpper();
                 mes2.GetComponent<TextMeshProUGUI>().text=((Desde.AddMonths(-4)).ToString("MMM")).ToUpper();
                 mes3.GetComponent<TextMeshProUGUI>().text=((Desde.AddMonths(-3)).ToString("MMM")).ToUpper();
                 mes4.GetComponent<TextMeshProUGUI>().text=((Desde.AddMonths(-2)).ToString("MMM")).ToUpper();
                 mes5.GetComponent<TextMeshProUGUI>().text=((Desde.AddMonths(-1)).ToString("MMM")).ToUpper();
                mes6.GetComponent<TextMeshProUGUI>().text=(Desde.ToString("MMM")).ToUpper();

                if(prom>=220){
                    Prom1.GetComponent<TextMeshProUGUI>().text=""+prom;
                        promgraf1.SetActive(true);
                         Prom2.GetComponent<TextMeshProUGUI>().text="";
                        promgraf2.SetActive(false);
                        Prom3.GetComponent<TextMeshProUGUI>().text="";
                        promgraf3.SetActive(false);

                }
               else if(prom>=180 &&prom<220){
                    Prom2.GetComponent<TextMeshProUGUI>().text=""+prom;
                        promgraf2.SetActive(true);
                         Prom1.GetComponent<TextMeshProUGUI>().text="";
                        promgraf1.SetActive(false);
                        Prom3.GetComponent<TextMeshProUGUI>().text="";
                        promgraf3.SetActive(false);

                }
              else if(prom<180){
                    Prom3.GetComponent<TextMeshProUGUI>().text=""+prom;
                        promgraf3.SetActive(true);
                         Prom1.GetComponent<TextMeshProUGUI>().text="";
                        promgraf1.SetActive(false);
                        Prom2.GetComponent<TextMeshProUGUI>().text="";
                        promgraf2.SetActive(false);

                }

            
                if(double.Parse(ConsumoActual.GetComponent<TextMeshProUGUI>().text)>double.Parse(Consumoanterior.GetComponent<TextMeshProUGUI>().text)){
                    FlechaIncremento.SetActive(true);
                    FlechaBajo.SetActive(false);
                }
                if(double.Parse(ConsumoActual.GetComponent<TextMeshProUGUI>().text)<double.Parse(Consumoanterior.GetComponent<TextMeshProUGUI>().text)){
                    FlechaIncremento.SetActive(false);
                    FlechaBajo.SetActive(true);
                }
                if(VEstrato.Equals("1")||VEstrato.Equals("2")||VEstrato.Equals("3")){
             if(VMunicipio.Equals("LA DORADA")||VMunicipio.Equals("NORCASIA")||VMunicipio.Equals("VICTORIA")||
            VMunicipio.Equals("VITERBO")||VMunicipio.Equals("LA VIRGINIA")){
              if(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)>173){
                  KwSubsidiado.GetComponent<TextMeshProUGUI>().text="173";
                  KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text="173";
                  if(VEstrato.Equals("1")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor1;
                  }
                else if(VEstrato.Equals("2")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor2;
                  }
                  else if(VEstrato.Equals("3")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor3;
                  }
                  
                  ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text=""+ (double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)-173);
                  ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text=ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor4;
                  ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  ValorTotalConsumoActivo.GetComponent<TextMeshProUGUI>().text="" + (double.Parse(ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text)
                  +double.Parse(ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text));

                    }
               else{
                   KwSubsidiado.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                   KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                       if(VEstrato.Equals("1")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor1;
                     }
                    else if(VEstrato.Equals("2")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor2;
                  }
                    else if(VEstrato.Equals("3")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor3;
                  }
                   ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  ValorTotalConsumoActivo.GetComponent<TextMeshProUGUI>().text= ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text;
                     KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text="";
                  ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text="";
                  ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text=""; 
               }

         }
         else{
             if(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)>130){
                  KwSubsidiado.GetComponent<TextMeshProUGUI>().text="130";
                  KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text="130";
                      if(VEstrato.Equals("1")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor1;
                  }
                else if(VEstrato.Equals("2")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor2;
                  }
                  else if(VEstrato.Equals("3")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor3;
                  }
                  ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text=""+ (double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)-130);
                  ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor4;
                  ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  ValorTotalConsumoActivo.GetComponent<TextMeshProUGUI>().text="" + (double.Parse(ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text)
                  +double.Parse(ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text));

                    }
               else{
                   KwSubsidiado.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                   KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                       if(VEstrato.Equals("1")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor1;
                  }
                else if(VEstrato.Equals("2")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor2;
                  }
                  else if(VEstrato.Equals("3")){
                      ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor3;
                  }
                   ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  ValorTotalConsumoActivo.GetComponent<TextMeshProUGUI>().text= ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text;
                 KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text="";
                  ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text="";
                  ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text=""; 
               }
           
         }
        
         }
         else{
                   KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text=TotalKilowatios.GetComponent<TextMeshProUGUI>().text;
                   KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text="0";
                       if(VEstrato.Equals("4")){
                      ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor4;
                     }
                    else if(VEstrato.Equals("5")||VEstrato.Equals("6")){
                      ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text="" +modificacion.Valor5;
                    }
                   
                   ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text=""+(double.Parse(KwSinSubsidiado.GetComponent<TextMeshProUGUI>().text)
                  *double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text)); 
                  ValorTotalConsumoActivo.GetComponent<TextMeshProUGUI>().text= ValorConsumoSinconSubsidio.GetComponent<TextMeshProUGUI>().text;
                     KwSubsidiado.GetComponent<TextMeshProUGUI>().text="";
                   ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text="";
                   ValorConsumoconSubsidio.GetComponent<TextMeshProUGUI>().text=""; 
              
               }
            TarifaKilowatiosSubsidiadosTotales.GetComponent<TextMeshProUGUI>().text=
            "$"+((Convert.ToInt32(double.Parse(KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text)*(Convert.ToInt32(double.Parse(ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text)))))-
            (Convert.ToInt32(double.Parse(KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text)*(Convert.ToInt32(double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text))))));
            valorKilowatiosCompleto=((Convert.ToInt32(double.Parse(KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text)*(Convert.ToInt32(double.Parse(ValorKlSubsidiado.GetComponent<TextMeshProUGUI>().text)))))
            -(Convert.ToInt32(double.Parse(KilowatiosSubsiados.GetComponent<TextMeshProUGUI>().text)*(Convert.ToInt32(double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text))))));
            
            
            if(ValorSaldosanteriores.GetComponent<TMP_InputField>().text!=""){
                ValorservicioTotal.GetComponent<TextMeshProUGUI>().text=""+Convert.ToInt32(double.Parse(ValorServicioEnergiaFinal.GetComponent<TextMeshProUGUI>().text)
                +double.Parse(ValorTotalCreditoSomo.GetComponent<TextMeshProUGUI>().text) + double.Parse(ValorTotalOtrosProductos.GetComponent<TextMeshProUGUI>().text)
               +double.Parse(ValorTotalImpuestoo.GetComponent<TextMeshProUGUI>().text) +double.Parse(ValorTotalAseo.GetComponent<TextMeshProUGUI>().text )
                +double.Parse(ValorSaldosanteriores.GetComponent<TMP_InputField>().text));
            }
            else{
                  ValorservicioTotal.GetComponent<TextMeshProUGUI>().text=""+(int)(double.Parse(ValorServicioEnergiaFinal.GetComponent<TextMeshProUGUI>().text)
                +double.Parse(ValorTotalCreditoSomo.GetComponent<TextMeshProUGUI>().text) + double.Parse(ValorTotalOtrosProductos.GetComponent<TextMeshProUGUI>().text)
               +double.Parse(ValorTotalImpuestoo.GetComponent<TextMeshProUGUI>().text) +double.Parse(ValorTotalAseo.GetComponent<TextMeshProUGUI>().text ));
            }



            
            if(Saldoanterior.GetComponent<TMP_InputField>().text!=""){
            sumaTotal=(valorKilowatiosCompletoSinsubsidio+valorKilowatiosCompleto)+8120+5+Convert.ToInt32(double.Parse(Saldoanterior.GetComponent<TMP_InputField>().text));
            MesesDeuda.GetComponent<TextMeshProUGUI>().text="1";
            ValorServicioEnergia.GetComponent<TextMeshProUGUI>().text="$"+sumaTotal;
           ValorServicioEnergiaFinal.GetComponent<TextMeshProUGUI>().text=""+ ((valorKilowatiosCompletoSinsubsidio+valorKilowatiosCompleto)+8120+5);
            }
            else{
            MesesDeuda.GetComponent<TextMeshProUGUI>().text="0";
            sumaTotal=(valorKilowatiosCompletoSinsubsidio+valorKilowatiosCompleto)+8120+5;
            ValorServicioEnergia.GetComponent<TextMeshProUGUI>().text="$"+sumaTotal;
            ValorServicioEnergiaFinal.GetComponent<TextMeshProUGUI>().text=""+ sumaTotal;
            
            }
                TarifaKilowatiosTotales.GetComponent<TextMeshProUGUI>().text="$"+(Convert.ToInt32(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)*(Convert.ToInt32(double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text)))));
                valorKilowatiosCompletoSinsubsidio=Convert.ToInt32(double.Parse(TotalKilowatios.GetComponent<TextMeshProUGUI>().text)*(Convert.ToInt32(double.Parse(ValorKlSinSubsidiado.GetComponent<TextMeshProUGUI>().text))));
        
         }

         if(LecturaActualReactiva.GetComponent<TMP_InputField>().text!="" && LecturaAnteriorReactiva.GetComponent<TMP_InputField>().text!=""){
             ConsumoReactiva.GetComponent<TextMeshProUGUI>().text="" + ((double.Parse(LecturaActualReactiva.GetComponent<TMP_InputField>().text))
             -(double.Parse(LecturaAnteriorReactiva.GetComponent<TextMeshProUGUI>().text)));
             TotalKilowatios.GetComponent<TextMeshProUGUI>().text="" + (((double.Parse(LecturaActualReactiva.GetComponent<TMP_InputField>().text))
             -(double.Parse(LecturaAnteriorReactiva.GetComponent<TMP_InputField>().text)))*double.Parse(FactorMultiplicacionReactiva.GetComponent<TMP_InputField>().text));
         }


    
    
    
    if(ValorComprasomos.GetComponent<TMP_InputField>().text!="" && cuotaComprasomos.GetComponent<TMP_InputField>().text!=""){
        CapitalComprasomos.GetComponent<TextMeshProUGUI>().text=""+Convert.ToInt32((double.Parse(ValorComprasomos.GetComponent<TMP_InputField>().text)/double.Parse(cuotaComprasomos.GetComponent<TMP_InputField>().text))
        *(double.Parse(cuotaComprasomos.GetComponent<TMP_InputField>().text)-2));
        segundaaComprasomos.GetComponent<TextMeshProUGUI>().text=ValorComprasomos.GetComponent<TMP_InputField>().text;
        cuotaFinalComprasomos.GetComponent<TextMeshProUGUI>().text=""+ ((double.Parse(cuotaComprasomos.GetComponent<TMP_InputField>().text))-1);
        SaldoComprasomos.GetComponent<TextMeshProUGUI>().text=""+Convert.ToInt32(double.Parse(ValorComprasomos.GetComponent<TMP_InputField>().text)/double.Parse(cuotaComprasomos.GetComponent<TMP_InputField>().text));
        TotalComprasomos.GetComponent<TextMeshProUGUI>().text=""+Convert.ToInt32(double.Parse(ValorComprasomos.GetComponent<TMP_InputField>().text)/double.Parse(cuotaComprasomos.GetComponent<TMP_InputField>().text));
        ValorTotalCreditoSomo.GetComponent<TextMeshProUGUI>().text=TotalComprasomos.GetComponent<TextMeshProUGUI>().text;
    }
 
        if(ValorOtros.GetComponent<TMP_InputField>().text!=""){
            ValorFinalOtros.GetComponent<TextMeshProUGUI>().text=ValorOtros.GetComponent<TMP_InputField>().text;
            ValorTotalOtrosProductos.GetComponent<TextMeshProUGUI>().text=ValorOtros.GetComponent<TMP_InputField>().text;
        }

        if(ValorAseo.GetComponent<TMP_InputField>().text!=""){
            ValorfinalAseo.GetComponent<TextMeshProUGUI>().text=ValorAseo.GetComponent<TMP_InputField>().text;
            ValorTotalAseo.GetComponent<TextMeshProUGUI>().text=ValorAseo.GetComponent<TMP_InputField>().text;
        }


    }

     void DropdownItemSelected1(TMP_Dropdown dropdown){
            int index=dropdown.value;
            VMunicipio=dropdown.options[index].text;
            Municipio2.GetComponent<TextMeshProUGUI>().text=dropdown.options[index].text;
    }

        void DropdownItemSelected2(TMP_Dropdown dropdown){
            int index=dropdown.value;
            VEstrato=dropdown.options[index].text;
            if(dropdown.options[index].text=="1"){
                Subsidio.GetComponent<TextMeshProUGUI>().text="-60%";
            }
            else if(dropdown.options[index].text=="2"){
                Subsidio.GetComponent<TextMeshProUGUI>().text="-50%";
            }
            
           else if(dropdown.options[index].text=="3"){
               Subsidio.GetComponent<TextMeshProUGUI>().text="-15%";
                
            }
            else{
                Subsidio.GetComponent<TextMeshProUGUI>().text="";
            }
            
        }

       public string VMunicipio   // 
  {
    get { return vmunicipio; }
    set { vmunicipio = value; }
  }

     
     public string VEstrato   // 
  {
    get { return vestrato; }
    set { vestrato = value; }
  }   
 
}
