int tempCm;
string tempNev;
for(int i = 0; i < cm.Length; i++) {
    for(int j = 0; j < cm.Length-1; j++) {

        if(cm[j] > cm[j + 1]) {

            tempCm = cm[j];
            tempNev = nev[j];

            cm[j] = cm[j + 1];
            cm[j + 1] = tempCm;

            nev[j] = nev[j + 1];
            nev[j + 1] = tempNev;

        }

    }
}

int ll = lista.Length;
int csere2;

for(int i = ll - 1; i > 0; i--){
    for(int j = 0; j < i; j++){
        if(lista[j] > lista[j + 1]){
            csere2 = lista[j];
            lista[j] = lista[j+1];
            lista[j + 1] = csere2;
        };
    };
};
