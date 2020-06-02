export interface Tarjeta {
    idTarjeta: number;
    idUsuario: number;
    idTipoTarjeta: number;
    idBanco: number;
    numero: number;
    fechaVencimineto: string;
    cvc: number;
    estatus: number;
}
