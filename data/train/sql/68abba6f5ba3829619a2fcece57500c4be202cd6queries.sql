-- 1
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ ONLY;
    SELECT * FROM free_seats(3);
COMMIT;

-- 2
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ WRITE;
    SELECT * FROM book_seat(2, 3, 4);
COMMIT;

-- 3
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ WRITE;
    SELECT * FROM update_booking(2, 3, 4);
COMMIT;

-- 4
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ WRITE;
    SELECT * FROM buy_seat(2, 3, 6);
COMMIT;

-- 5
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ WRITE;
	SELECT * FROM buy_seat_by_booking(2, 3, 4);
COMMIT;

-- 6
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ WRITE;
	SELECT * FROM block_flight(3);
COMMIT;

-- 7
START TRANSACTION ISOLATION LEVEL SERIALIZABLE READ ONLY;
	SELECT * FROM flight_statistics();
COMMIT;