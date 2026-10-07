**Краткий пересказ:** Подготовил чистый вариант текста без BBCode-тегов (без жирного шрифта и ссылок), предназначенный специально для файла `description.txt`, который отображается внутри игры в tModLoader.

---

### Текст для файла `description.txt`:

Notice!:
This mod is a complete rework/fork of the "1HP playthrough v0.1.1" mod.
• The code has been rewritten from scratch with AI to fix crashes, death screen freezes, and multiplayer desyncs.
• The author is not a programmer and cannot guarantee the overall stability of the mod.
• This mod was created to solve a personal issue, which is described below in the "Compatibility Note" section; therefore, further updates are most likely not planned.

This mod was created specifically to work properly with Fargo's Souls Mod and Calamity Mod in multiplayer:
• Clamps player max HP to 1 safely.
• Preserves Life Crystal & Life Fruit progression (triggers vanilla/modded events normally).
• Does not alter respawn timers (fixes soft-locks in Fargo's Eternity mode).
• Safe for character save files.
• Clean code without incompatible IL hooks.
• Fixed Crimson Effigy bug where the buff dropped player HP to 0, marking the player as dead and breaking Wormhole Potion teleportation.

Important Compatibility Note (Fargo + Calamity):
• If you encounter respawn issues when playing Fargo's Souls + Calamity Mod (e.g. death screen freeze: "Respawn failed... only one respawn allowed during boss fight"), set Eternity Boss AI priority OVER Calamity.
• How to fix:

1. Enter your world.
2. In inventory (left of minimap), click the top toggle: "Eternity Boss AI Priority over Calamity".
3. Save & Exit the world.
4. Reload mods (Main Menu -> Workshop -> Manage Mods -> Reload Mods).
5. Re-enter the world, kill any boss (or die to one).
6. Save & Exit again. Re-enter the world - the bug should be completely gone.

• If you encounter any bugs or issues, please report them in the mod comments. Thank you

---

Предупреждение!:
Данный мод является исправленным форком мода "1HP playthrough v0.1.1".
• Код полностью переписан с нуля с помощью ИИ для устранения вылетов, зависаний на экране смерти и рассинхронов в мультиплеере.
• Автор не является программистом и не ручается за абсолютную стабильность мода.
• Мод создавался для решения личной проблемы, которая описана ниже в блоке "информация о совместимости", поэтому дальнейшие обновления скорее всего не планируются.

Мод создан специально для корректной совместной работы с Fargo's Souls Mod, Calamity Mod в мультиплеере:
• Фиксирует максимальное здоровье игрока на 1 хп.
• Полная поддержка Кристаллов и Фруктов жизни (Армия гоблинов, Глаз Ктулху и Медсестра приходят штатно).
• Не трогает таймеры смерти (полностью устранены зависания на 5 секундах и бессмертие боссов).
• Не перезаписывает файлы сохранений - 100% безопасен для ваших персонажей.
• Чистый код без несовместимых IL-хуков.
• Исправлен баг с "Чучелом багрянца": бафф больше не сбрасывает здоровье до 0 хп, не ломает телепортацию Зельем червоточины и не имитирует смерть игрока.

Важная информация о совместимости (Fargo + Calamity):
• Если у вас возникли проблемы с возрождением при игре с Fargo + Calamity (зависаете на экране смерти с надписью "Возрождение невозможно: В режиме Mods.FargowiltasSouls.UI.MasochistMode в мультиплеере разрешено только одно возрождение во время битвы с боссом!"), сделайте приоритет ИИ боссов Вечности НАД Calamity.
• Как настроить:

1. Зайдите в мир.
2. В инвентаре слева от миникарты выберите верхний переключатель: «Приоритет ИИ боссов Вечности над Calamity».
3. Сохранитесь и выйдите из мира.
4. Перезайдите в игру и перезагрузите моды (Главное меню -> Мастерская -> Управление модами -> Перезагрузить моды).
5. Зайдите в мир и убейте любого босса (можно через чит-панель) или умрите от него.
6. Сохранитесь и выйдите еще раз. После повторного входа баг пропадет.

• Если в моде будут обнаружены баги или недочеты, просьба сообщить в комментарии к моду. Спасибо

Source code: [https://github.com/aqqbuyer/Safe-1-HP-Fargo-Calamity-Compatible-](https://github.com/aqqbuyer/Safe-1-HP-Fargo-Calamity-Compatible-)
Fixed fork of: [https://steamcommunity.com/sharedfiles/filedetails/?id=2964415625](https://steamcommunity.com/sharedfiles/filedetails/?id=2964415625)
