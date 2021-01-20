//import { OrderModel } from "../Models/OrderModel";

import { forEach } from "lodash";

export class OrderManager {
    goods: { id: number, count: number, price: number }[] = [];
    selectgoodtypes: string[] = [];
    selectproducer: string[] = [];


    constructor() {
        $('.selectgoodtype').selectpicker();
        this.initIvents();
    }

    applayFilters() { }

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
            //alert(goodPrice.text());

            target.hide();
            $(".goodnumber-delete-" + goodId).show();
            goodNumber.attr("disabled", "disabled")
            this.goods.push({
                id: goodId, count: Number(goodNumber.val()),
                price: Number(goodPrice.text().replace(',', '.'))
            });//element.val -> element.text

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
            //$(".goodnumber-add-" + goodId).show();
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
            const selectedGoodtypes = $("#selectgoodtype").val();
            $("tr").hide();
            this.selectgoodtypes.splice(0, this.selectgoodtypes.length);
            (selectedGoodtypes as string[]).forEach(gt => {
                if (!this.selectproducer.includes($(".goodtypecode-" + gt).data("goodid"))) {
                $(".goodtypecode-" + gt).show();
                this.selectgoodtypes.push($(".goodtypecode-" + gt).data("goodid"));
                }                
            });
            alert(this.selectgoodtypes);
        })

        $("#selectproducer").on("changed.bs.select", () => {
            const selectedProducers = $("#selectproducer").val();
            $("tr").hide();
            this.selectproducer.splice(0, this.selectproducer.length);
            (selectedProducers as string[]).forEach(pd => {
                if (!this.selectgoodtypes.includes($(".producercode-" + pd).data("goodid"))) {
                    $(".producercode-" + pd).show();
                this.selectproducer.push($(".producercode-" + pd).data("goodid"));
                }                
            });
            alert(this.selectproducer);
        })
    }
}