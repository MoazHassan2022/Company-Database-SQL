SELECT department_id, department_name, d.location_id, l.city FROM departments as d, locations as l WHERE d.location_id = l.location_id AND l.city = Seatle;