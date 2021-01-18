//import { OrderModel } from "../Models/OrderModel";

export class OrderManager
{

    constructor()
    {
        this.initIvents();
    }

    initIvents() {
        $(".goodnumber-input").on("input", ev => {
            const target = $(ev.target);
            const goodId = target.data("goodid");
            alert(goodId);
        })
    }
}