//import { OrderModel } from "../Models/OrderModel";

export class OrderManager
{
    goods: { id: number, count: number, price: number }[] = [];

    constructor()
    {
        this.initIvents();
    }

    initIvents() {
        $(".goodnumber-input").on("input", ev => {
            const target = $(ev.target);
            const goodId = target.data("goodid");

            if (Number(target.val()) > 0) {
                $(".goddnumber-add-" + goodId).show();
            }
            else {
                $(".goddnumber-add-" + goodId).hide();
            }
        })

        $(".goodnumber-add").on("click", ev => {
            const target = $(ev.target);
            const goodId = target.data("goodid");
            const elem = $(".goddnumber-input-" + goodId);

            target.hide();
            $(".goddnumber-delete-" + goodId).show();
            elem.attr("disabled", "disabled")
            this.goods.push({ id: goodId, count: Number(elem.val()), price: 1 });//element.val -> element.text

            let total = 0;
            this.goods.forEach(item => {
                total += item.count * item.price;
            });

            alert(total);
        })

        $(".goodnumber-delete").on("click", ev => {
            const target = $(ev.target);
            const goodId = target.data("goodid");

            target.hide();
            $(".goddnumber-add-" + goodId).show();
            $(".goddnumber-input-" + goodId).removeAttr("disabled");
            $(".goddnumber-input-" + goodId).val(0);
        })
    }
}