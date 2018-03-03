using System;
using System.Collections.Generic;
using System.Linq;
using Tabloide.Models;

namespace Tabloide.Services.Showcase
{
	public class ShowcaseService : IShowcaseService
	{
		public IList<ProductShowcase> GetPersonalProductRecommendations()
		{
			return new List<ProductShowcase> {
				new ProductShowcase("SUGERIDOS PARA VOCÊ") {
					new Product {
						Code = 7898954167183L,
						Name = "Cápsulas de Café Espresso Intenso Aroma Selezione Compatível Nespresso - 10 Unidades",
						Description = "Tomar uma bebida quente a qualquer hora do dia se tornou muito mais fácil. Com as Cápsulas Aroma Selezione Café Espresso Intenso - 10 unidades você terá sempre à sua disposição uma xícara de sofisticação com sabores incomparáveis. As cápsulas são compatíveis com Nespresso.",
						NormalPrice = 12.5d,
						PromotionPrice = 11.99d,
						CardPrice = 11.24d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/121701/6/121701698_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					},
					new Product {
						Code = 7896005801826L,
						Name = "Café em Pó Extra Forte 3 Corações 500g",
						Description = "Café em pó, torrado e moído extra forte. Embalagem com 500g. Marca: 3 Corações.",
						NormalPrice = 13.4d,
						PromotionPrice = 12.9d,
						CardPrice = 11.99d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/sku/25050/2/25050274_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					},
					new Product {
						Code = 7892840808471L,
						Name = "Gatorade Laranja Pet 500ml",
						Description = "O nosso corpo transpira para dissipar o calor do organismo de uma forma saudável, e isso ocorre principalmente na prática de atividades físicas, mas também em dias quentes e em ambientes fechados. Gatorade Laranja é um produto desenvolvido cientificamente para repor os nutrientes perdidos com o suor e também hidratar o corpo. Sua fórmula contém a quantidade ideal de carboidratos, sódio e potássio, que estimulam a rápida absorção dos líquidos pelo organismo e ajudam a manter o equilíbrio do corpo.",
						NormalPrice = 5.99d,
						PromotionPrice = 5.33d,
						CardPrice = 4.99d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/15936/0/15936071_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					},
					new Product {
						Code = 9002490100193L,
						Name = "Energético Red Bull 250ml",
						Description = "Para Enfrentar Diariamente Todos Os Nossos Compromissos, Precisamos Sempre Repor As Energias Do Corpo. Com Uma Combinação Única De Ingredientes, O Energético Red Bull 250ml Foi Desenvolvido Para Quem Precisa Estar Ativo Fisicamente E Mentalmente E Para Aqueles Que Tem Uma Vida Intensa.",
						NormalPrice = 7.99d,
						PromotionPrice = 7.68d,
						CardPrice = 7.41d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/16026/0/16026011_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					}
				},
				new ProductShowcase("VOCÊ TAMBÉM PODE GOSTAR") {
					new Product {
						Code = 4002103248675L,
						Name = "Cerveja Alemã Clara Tradicional Erdinger - 500ml",
						Description = "A Erdinger Clara é uma cerveja de trigo premium, com levedura fina e tradicional maturação dentro da própria garrafa, similar às champanhes. Uma cerveja leve, viva, muito aromática e refrescante, com sabor incomparável. A clássica entre as cervejas de trigo!",
						NormalPrice = 21.67d,
						PromotionPrice = 20.99d,
						CardPrice = 18.91d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/7305/5/7305516_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					},
					new Product {
						Code = 3045140105502L,
						Name = "Chocolate Milka Alpine Milk 100 g",
						Description = "O delicioso chocolate Milka é fabricado com o verdadeiro sabor dos Alpes suíços, com uma fórmula deliciosamente cremosa. É uma barra cativante e surpreendente com um sabor irresistível. É uma excelente opção para presentear. Composto por ingredientes de ótima qualidade que fazem toda a diferença a cada mordida. Delicie-se com esta preciosidade!",
						NormalPrice = 10.51d,
						PromotionPrice = 9.9d,
						CardPrice = 9.4d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/112913/9/112913980_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					}
				},
				new ProductShowcase("OFERTAS ESPECIAIS") {
					new Product {
						Code = 7891000113608L,
						Name = "Caixa de Bombom Especialidades 300g - Nestlé",
						Description = "A Caixa de Especialidades Nestlé junta os maiores sucessos da Nestlé em um lugar só. São variedades de chocolates em miniaturas que enchem os olhos e agradam a todos os gostos. Agora, além de delícias como Alpino, Charge, Chokito, Crunch e Sensação, a Caixa de Especialidades Nestlé traz o bombom Nestlé Classic Ao Leite!",
						NormalPrice = 14.79d,
						PromotionPrice = 12.75d,
						CardPrice = 10.48d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/125713/0/125713012_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					},
					new Product {
						Code = 7622300741013L,
						Name = "Biscoito Recheado Trakinas Chocolate 143g - Nabisco",
						Description = "Biscoito Trakinas De Chocolate Com Recheio Sabor Chocolate Adicionado De Vitaminas E Minerais, Trakinas É Também Um Biscoito Divertido Que Toda Criançada Conhece E Adora, Trakinas É O Biscoito Que É A Sua Cara, O Primeiro Biscoito Recheado Com Farinha Integral.",
						NormalPrice = 3.15d,
						PromotionPrice = 2.86d,
						CardPrice = 2.44d,
						ImageSource = "https://images-americanas.b2w.io/produtos/01/00/item/19602/9/19602997_1GG.jpg",
						ExpirationDate = DateTimeOffset.Now.AddDays(10d)
					}
				}
			};
		}
	}
}
