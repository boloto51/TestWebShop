import { forEach } from "lodash";
import { NetSender } from "../NetSender";

export class OrderManager {
    goods: { id: number, count: number, price: number }[] = [];
    selectgoodtypes: any;
    selectproducer: any;
    private orderCreate: string;

    constructor(orderCreate: string) {
        this.orderCreate = orderCreate;
        $('.selectgoodtype').selectpicker();
        this.initIvents();
    }

    applyFilters() {
        const types = $("#selectgoodtype").val() as any;
        const prods = $("#selectproducer").val() as any;
        $("tbody tr").hide();
        $('tbody tr').each((i, e) => {
            const t = $(e);
            const pr = t.data('prod');
            const tp = t.data('type');
            if (types.indexOf(tp) !== -1 && prods.indexOf(pr) !== -1) {
                t.show();
            }
            else {
                t.hide();
            }
        });
    }

    initIvents() {
        $(".goodnumber-input").on("input", ev => {
            const target = $(ev.target);
            const goodId = target.data("goodid");

            if (Number(target.val()) > 0) {
                $(".goodnumber-add-" + goodId).show();
            }
            else {
                $(".goodnumber-add-" + goodId).hide();
            }
        })

        $(".goodnumber-add").on("click", ev => {
            const target = $(ev.target);
            const goodId = target.data("goodid");
            const goodNumber = $(".goodnumber-input-" + goodId);
            const goodPrice = $(".goodprice-" + goodId);

            target.hide();
            $(".goodnumber-delete-" + goodId).show();
            goodNumber.attr("disabled", "disabled")
            this.goods.push({
                id: goodId, count: Number(goodNumber.val()),
                price: Number(goodPrice.text().replace(',', '.'))
            });

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
            $(".goodnumber-input-" + goodId).removeAttr("disabled");
            $(".goodnumber-input-" + goodId).val(0);

            let count = 0;
            this.goods.forEach(item => {
                if (Number(item.id) == Number(goodId)) {
                    this.goods.splice(count, 1);
                }
                count += 1;
            });
        })

        $("#selectgoodtype").on("changed.bs.select", () => {
            const temp = $("#selectgoodtype");
            const types = $("#selectgoodtype").val();
            this.selectgoodtypes = $("#selectgoodtype").val();
            this.applyFilters();
        })

        $("#selectproducer").on("changed.bs.select", () => {
            this.selectproducer = $("#selectproducer").val() as string[];
            this.applyFilters();
        })

        $(".order-create").on("click", () => {
            NetSender.post(this.orderCreate, {
                Goods: this.goods
            }, () => {})
        })
    }
}