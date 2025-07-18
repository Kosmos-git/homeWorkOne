using System;

namespace bossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandsNormalAttack = "1";
            const string CommandsFireball = "2";
            const string CommandsExplosion = "3";
            const string CommandsTreatment = "4";

            Random random = new Random();

            int healthPointsBoss = 100;
            int attackBoss;
            int minAttackBoss = 12;
            int maxAttackBoss = 18;

            float healthPointsPlayer = 100f;
            int maxhealthPointsPlayer = 100;
            int attackPlayer;
            int attackFireball;
            int attackExplosion;
            float manaPlayer = 100f;
            int maxManaPlayer = 100;

            int minAttackPlayer = 10;
            int maxAttackPlayer = 16;
            int minAttackFireball = 15;
            int maxAttackFireball = 21;
            int minAttackExplosion = 20;
            int maxAttackExplosion = 26;

            int manaCosts = 40;

            int numberUsesOfTreatment = 0;
            int maxNumberUsesOfTreatment = 3;

            int remainderNumberUsesOfTreatment;

            int amountHealthPointsRestored;
            int minAmountHealthPointsRestored;
            int maxAmountHealthPointsRestored;

            int amountManaRestored;
            int minAmountManaRestored;
            int maxAmountManaRestored;

            int transferToTenPercent = 10;
            int transferToTwentyFivePercent = 4;

            bool isUsedFireball = false;

            string historyOfBattle = "";

            string skillsPlayer = $"Твои умения:\n\n" +
                                    $"{CommandsNormalAttack} - Обычная атака. Наносит от {minAttackPlayer} до {maxAttackPlayer} урона.\n\n" +
                                    $"{CommandsFireball} - Огненный шар, который тратит {manaCosts} маны. Наносит от {minAttackFireball} до {maxAttackFireball} урона.\n\n" +
                                    $"{CommandsExplosion} - Взрыв. Можно вызывать, только если был использован огненный шар. " +
                                                   $"Для повторного применения надо повторно использовать огненный шар. Наносит от {minAttackExplosion} до {maxAttackExplosion} урона.\n\n" +
                                    $"{CommandsTreatment} - Лечение. Восстанавливает здоровье и ману, но не больше их максимального значения. Можно использовать только три раза.\n\n";

            Console.WriteLine("Это финальное испытание: бой с Боссом. Прояви себя как настоящий герой - сражайся до последнего вздоха!!\n");

            while (healthPointsPlayer > 0 && healthPointsBoss > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 24);
                Console.Write($"Информация:\n\n" +
                              $"    Количество жизней Босса: {healthPointsBoss}\n\n" +
                              $"    Количество жизней Игрока: {healthPointsPlayer}\n\n" +
                              $"    Количество маны Игрока: {manaPlayer}\n\n");

                Console.WriteLine($"События боя:\n\n" + historyOfBattle);

                Console.SetCursorPosition(0, 0);
                Console.WriteLine(skillsPlayer);

                Console.Write("Выберете умение: ");

                switch (Console.ReadLine())
                {
                    case CommandsNormalAttack:
                        attackPlayer = random.Next(minAttackPlayer, maxAttackPlayer);
                        healthPointsBoss -= attackPlayer;
                        historyOfBattle += $"   Герой: Обычная атака: Босс -{attackPlayer} очков здоровья.\n";
                        Console.WriteLine($"\nГерой: Обычная атака: Босс -{attackPlayer} очков здоровья.\n");
                        break;
                    case CommandsFireball:
                        if (manaCosts <= manaPlayer)
                        {
                            manaPlayer -= manaCosts;
                            attackFireball = random.Next(minAttackFireball, maxAttackFireball);
                            healthPointsBoss -= attackFireball;
                            historyOfBattle += $"   Герой: Огненный шар: Босс -{attackFireball} очков здоровья.\n";
                            Console.WriteLine($"\nГерой: Огненный шар: Босс -{attackFireball} очков здоровья.\n");
                            isUsedFireball = true;
                        }
                        else
                        {
                            historyOfBattle += $"   Герой: Недостаточно маны. Пропуск хода.\n";
                            Console.WriteLine("\nНедостаточно маны. Ты пропускаешь свой ход\n");
                        }
                        break;
                    case CommandsExplosion:
                        if (isUsedFireball)
                        {
                            attackExplosion = random.Next(minAttackExplosion, maxAttackExplosion);
                            healthPointsBoss -= attackExplosion;
                            historyOfBattle += $"   Герой: Взрыв: Босс -{attackExplosion} очков здоровья.\n";
                            Console.WriteLine($"\nГерой: Взрыв: Босс -{attackExplosion} очков здоровья.\n");
                            isUsedFireball = false;
                        }
                        else
                        {
                            historyOfBattle += $"   Герой: Перед умением - 'Взрыв' необходимо использовать умение 'Огненный шар'. Пропуск хода.\n";
                            Console.WriteLine("\nГерой: Перед умением - 'Взрыв' необходимо использовать умение 'Огненный шар'. Ты пропускаешь свой ход.\n");
                        }
                        break;
                    case CommandsTreatment:
                        if (numberUsesOfTreatment < maxNumberUsesOfTreatment)
                        {
                            minAmountHealthPointsRestored = Convert.ToInt32((Convert.ToSingle(maxhealthPointsPlayer) - healthPointsPlayer) / transferToTenPercent);
                            maxAmountHealthPointsRestored = Convert.ToInt32((Convert.ToSingle(maxhealthPointsPlayer) - healthPointsPlayer) / transferToTwentyFivePercent);
                            amountHealthPointsRestored = random.Next(minAmountHealthPointsRestored, maxAmountHealthPointsRestored);
                            healthPointsPlayer += amountHealthPointsRestored;

                            minAmountManaRestored = Convert.ToInt32((Convert.ToSingle(maxManaPlayer) - manaPlayer) / transferToTwentyFivePercent);
                            maxAmountManaRestored = Convert.ToInt32(Convert.ToSingle(maxManaPlayer) - manaPlayer);
                            amountManaRestored = random.Next(minAmountManaRestored, maxAmountManaRestored);
                            manaPlayer += amountManaRestored;

                            remainderNumberUsesOfTreatment = maxNumberUsesOfTreatment - numberUsesOfTreatment - 1;

                            historyOfBattle += $"   Герой: Лечение: Герой +{amountHealthPointsRestored} очков здоровья, +{amountManaRestored} маны. Осталось: {remainderNumberUsesOfTreatment}\n";
                            Console.WriteLine($"\nГерой: Лечение: Герой +{amountHealthPointsRestored} очков здоровья, +{amountManaRestored} маны. Осталось: {remainderNumberUsesOfTreatment}\n");
                            numberUsesOfTreatment++;
                        }
                        else
                        {
                            historyOfBattle += $"   Герой: Умение - 'Лечение' использовано максимальное количество раз. Пропуск хода.\n";
                            Console.WriteLine("\nГерой: Умение - 'Лечение' использовано максимальное количество раз. Ты пропускаешь свой ход.\n");
                        }
                        break;
                    default:
                        historyOfBattle += $"   Герой: Выбрано неизвестное умение. Пропуск хода.\n";
                        Console.WriteLine("\nГерой: Выбрано неизвестное умение. Ты пропускаешь свой ход.\n");
                        break;
                }

                attackBoss = random.Next(minAttackBoss, maxAttackBoss);
                healthPointsPlayer -= attackBoss;
                historyOfBattle += $"   Босс: Обычная атака: Герой -{attackBoss} очков здоровья.\n";
                Console.WriteLine($"\nБосс: Обычная атака: Герой -{attackBoss} очков здоровья.\n");
                Console.WriteLine("Нажмите клавишу, чтобы продолжить..");
                Console.ReadKey();
            }

            if (healthPointsPlayer == 0 && healthPointsBoss == 0)
            {
                Console.WriteLine("\nНичья.");
            }
            else
            {
                if (healthPointsPlayer <= 0)
                {
                    Console.WriteLine("\nВы проиграли. Босс Вам не по зубам.");
                }
                else
                {
                    Console.WriteLine("\nБосс побежден! Поздравляем!");
                }
            }
        }
    }
}
