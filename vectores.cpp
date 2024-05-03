#include<stdio.h>
#include<string.h>

int main(){
int cal1[5],cal2[5],cal3[5];
float promedio;
char nombre [];
printf("Calculemos las calificaciones de los alumnos\n");


     for( int i=0; i<5; i++){
        printf("Dame el nombre de los alumnos : ");
        fflush(stdin);
        gets(nombre[i]);
      }

      printf("\n");
      for( int i=0; i<5; i++){
        printf("Escribe las calificaciones del parcial 1 :");
        scanf("%d",&cal1[i]);
      }
      printf("\n");
      for( int i=0; i<5; i++){
        printf("Escribe las calificaciones del parcial 2:");
        scanf("%d",&cal2[i]);
      }
      printf("\n");
      for( int i=0; i<5; i++){
        printf("Escribe las calificaciones del parcial 3: ");
        scanf("%d",&cal3[i]);
      }

        for( int i=0; i<5; i++){
        promedio= (cal1[i]+cal2[i]+cal3[i])/3;
        }
      printf("\n");
    for(int i=0; i<5; i++){
        printf("%s\n",name[i]);
        printf("%d\n Calificaciones primer parcial",cal1[i]);
        printf("%d\n calificaciones segundo parcial:",cal2[i]);
        printf("%d\n calificaciones tercer parcial:",cal3[i]);

    }



return 0;
}
